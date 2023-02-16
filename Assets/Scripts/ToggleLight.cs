using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleLight : MonoBehaviour
{
    public Light spotLight;
    public GameObject switchObject;
    public Vector3 switchRotation;
    public GameObject lightObject;
    public Material onMaterial;
    public Material offMaterial;
    public AudioSource onSound;
    public AudioSource offSound;
    public bool isOn = false;

    public void Toggle() {
        if (isOn) {
            spotLight.enabled = false;
            lightObject.GetComponent<Renderer>().material = offMaterial;
            switchObject.transform.Rotate(-switchRotation.x, -switchRotation.y, -switchRotation.z);
            offSound.Play();
            isOn = false;
        } else {
            spotLight.enabled = true;
            lightObject.GetComponent<Renderer>().material = onMaterial;
            switchObject.transform.Rotate(switchRotation.x, switchRotation.y, switchRotation.z);
            onSound.Play();
            isOn = true;
        }
    }
}
