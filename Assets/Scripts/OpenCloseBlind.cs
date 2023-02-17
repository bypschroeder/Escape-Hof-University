using System.Collections;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using UnityEngine;

public class OpenCloseBlind : MonoBehaviour
{
    private Animator animator;
    public GameObject switchDownObject;
    public GameObject switchUpObject;
    public Vector3 switchDownRotation;
    public Vector3 switchUpRotation;
    public AudioSource openSound;
    public AudioSource switchSoundOn;
    public AudioSource switchSoundOff;
    [HideInInspector]
    public bool isOpen = true;

    void Start() {
        animator = GetComponent<Animator>();
    }

    public void Open() {
        if (!isOpen && AnimationIsFinished()) {
            switchUpObject.transform.Rotate(switchUpRotation.x, switchUpRotation.y, switchUpRotation.z);
            switchSoundOn.Play();
            openSound.Play();
            isOpen = true;
            animator.SetTrigger("TrUp");
            StartCoroutine(WaitAndRotateUp());
        } else {
            return;
        }
    }

    public void Close() {
        if (isOpen && AnimationIsFinished()) {
            switchDownObject.transform.Rotate(switchDownRotation.x, switchDownRotation.y, switchDownRotation.z);
            switchSoundOn.Play();
            openSound.Play();
            isOpen = false;
            animator.SetTrigger("TrDown");
            StartCoroutine(WaitAndRotateDown());
        } else {
            return;
        }
    }

    bool AnimationIsFinished() {
        return animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1;
    }

    IEnumerator WaitAndRotateUp() {
        yield return new WaitForSeconds(8.0f);
        switchUpObject.transform.Rotate(-switchUpRotation.x, -switchUpRotation.y, -switchUpRotation.z);
        switchSoundOff.Play();
    }

    IEnumerator WaitAndRotateDown() {
    yield return new WaitForSeconds(8.0f);
        switchDownObject.transform.Rotate(-switchDownRotation.x, -switchDownRotation.y, -switchDownRotation.z);
        switchSoundOff.Play();
    }
}
