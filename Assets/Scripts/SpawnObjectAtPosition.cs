using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObjectAtPosition : MonoBehaviour
{
    public GameObject hint1;
    public GameObject hint2;
    public GameObject hint3;
    public GameObject hint4;
    public GameObject hint5;
    public GameObject hint6;
    public GameObject hint7;
    public GameObject hint8;

    public Transform spawnPosition;
    public AudioSource spawnSound;
    private bool hint1Spawned = false;
    private bool hint2Spawned = false;
    private bool hint3Spawned = false;
    private bool hint4Spawned = false;
    private bool hint5Spawned = false;
    private bool hint6Spawned = false;
    private bool hint7Spawned = false;
    private bool hint8Spawned = false;

    public void SpawnObject()
    {
        if (!hint1Spawned)
        {
            Instantiate(hint1, spawnPosition.position, spawnPosition.rotation);
            spawnSound.Play();
            hint1Spawned = true;
            Debug.Log("Spawned object");
        } 
        else if (!hint2Spawned && hint1Spawned)
        {
            Instantiate(hint2, spawnPosition.position, spawnPosition.rotation);
            spawnSound.Play();
            hint2Spawned = true;
            Debug.Log("Spawned object");
        }
        else if (!hint3Spawned && hint2Spawned)
        {
            Instantiate(hint3, spawnPosition.position, spawnPosition.rotation);
            spawnSound.Play();
            hint3Spawned = true;
            Debug.Log("Spawned object");
        }
        else if (!hint4Spawned && hint3Spawned)
        {
            Instantiate(hint4, spawnPosition.position, spawnPosition.rotation);
            spawnSound.Play();
            hint4Spawned = true;
            Debug.Log("Spawned object");
        }
        else if (!hint5Spawned && hint4Spawned)
        {
            Instantiate(hint5, spawnPosition.position, spawnPosition.rotation);
            spawnSound.Play();
            hint5Spawned = true;
            Debug.Log("Spawned object");
        }
        else if (!hint6Spawned && hint5Spawned)
        {
            Instantiate(hint6, spawnPosition.position, spawnPosition.rotation);
            spawnSound.Play();
            hint6Spawned = true;
            Debug.Log("Spawned object");
        }
        else if (!hint7Spawned && hint6Spawned)
        {
            Instantiate(hint7, spawnPosition.position, spawnPosition.rotation);
            spawnSound.Play();
            hint7Spawned = true;
            Debug.Log("Spawned object");
        }
        else if (!hint8Spawned && hint7Spawned)
        {
            Instantiate(hint8, spawnPosition.position, spawnPosition.rotation);
            spawnSound.Play();
            hint8Spawned = true;
            Debug.Log("Spawned object");
        }
    }
}
