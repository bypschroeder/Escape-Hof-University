using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjectAtPosition : MonoBehaviour
{
    public GameObject objectToSpawn;
    public Transform spawnPosition;
    public AudioSource spawnSound;
    private bool isSpawned = false;

    public void SpawnObject()
    {
        if (isSpawned) {
            Debug.Log("Object already spawned");
            return;
        } else {
            Instantiate(objectToSpawn, spawnPosition.position, spawnPosition.rotation);
            spawnSound.Play();
            isSpawned = true;
            Debug.Log("Spawned object");
        }
    }
}
