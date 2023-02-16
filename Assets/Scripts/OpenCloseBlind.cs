using System.Collections;
using System.Collections.Generic;
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
    private bool isOpen = true;

    void Start() {
        animator = GetComponent<Animator>();
    }

    public void Open() {
        if (!isOpen && AnimationIsFinished()) {
            switchUpObject.transform.Rotate(switchDownRotation.x, switchDownRotation.y, switchDownRotation.z);
            // openSound.Play();
            isOpen = true;
            animator.SetTrigger("TrUp");
        } else {
            return;
        }
    }

    public void Close() {
        if (isOpen && AnimationIsFinished()) {
            switchDownObject.transform.Rotate(switchUpRotation.x, switchUpRotation.y, switchUpRotation.z);
            // openSound.Play();
            isOpen = false;
            animator.SetTrigger("TrDown");
        } else {
            return;
        }
    }

    bool AnimationIsFinished() {
        return animator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1;
    }
}
