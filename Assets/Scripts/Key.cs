using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class Key : MonoBehaviour
{
    public GameObject door;
    public GameObject door2;
    public GameObject keyhole;
    private bool doorIsFrozen = true;
    public AudioSource openSound;

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject == keyhole) {
            if (doorIsFrozen) {
                doorIsFrozen = false;
                door.GetComponent<CircularDrive>().enabled = true;
                door2.GetComponent<CircularDrive>().enabled = true;
                Debug.Log("Door is now unlocked");
                openSound.Play();
            }
        }
    }
}
