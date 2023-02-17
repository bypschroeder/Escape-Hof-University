using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakMirror : MonoBehaviour
{
    public GameObject hammerCollider;
    public GameObject brokenMirror;
    public AudioSource audioSource;

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject == hammerCollider) {
            audioSource.Play();
            Instantiate(brokenMirror, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
