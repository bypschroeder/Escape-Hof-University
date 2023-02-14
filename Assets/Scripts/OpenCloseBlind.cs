using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenCloseBlind : MonoBehaviour
{
    private Animator animator;
    public AudioSource openSound;
    private bool isOpen = true;

    void Start() {
        animator = GetComponent<Animator>();
    }

    public void Open() {
        if (!isOpen) {
            // openSound.Play();
            isOpen = true;
            animator.SetTrigger("TrUp");
        } else {
            return;
        }
    }

    public void Close() {
        if (isOpen) {
            // openSound.Play();
            isOpen = false;
            animator.SetTrigger("TrDown");
        } else {
            return;
        }
    }
}
