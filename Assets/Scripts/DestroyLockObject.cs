using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyLockObject : MonoBehaviour
{
    public GameObject lockCollider;
    public GameObject padlock;
    public AudioSource audioSource;

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject == lockCollider) {
            Destroy(padlock);
            audioSource.Play();
        }
    }
}
