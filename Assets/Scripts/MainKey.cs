using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainKey : MonoBehaviour
{
    public GameObject keyhole;
    public Animator animator;
    public GameObject confetti;
    public Transform confettiSpawn;
    public AudioSource successSound;

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject == keyhole) {
            successSound.Play();
            Instantiate(confetti, confettiSpawn.position, confettiSpawn.rotation);
            animator.SetTrigger("OpenDoor");
            Debug.Log("Main key is now unlocked");
        }
    }
}
