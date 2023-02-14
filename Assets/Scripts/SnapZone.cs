using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.InteractionSystem;

public class SnapZone : MonoBehaviour
{
    public GameObject snapObject;
    public GameObject snapZoneObject;

    [HideInInspector]
    public bool isSnapped = false;

    private void OnTriggerEnter(Collider other)
    {
        snapObject.transform.position = snapZoneObject.transform.position;
        snapObject.transform.rotation = snapZoneObject.transform.rotation;
        snapObject.GetComponent<Rigidbody>().isKinematic = true;
        snapZoneObject.SetActive(false);
        isSnapped = true;
    }

    private void Update() {
        if (isSnapped) {
            snapObject.transform.position = snapZoneObject.transform.position;
            snapObject.transform.rotation = snapZoneObject.transform.rotation;
        }   
    }
}
