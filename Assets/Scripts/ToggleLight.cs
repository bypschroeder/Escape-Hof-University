using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleLight : MonoBehaviour
{
    private Light light;
    public GameObject lightObject;
    public Material onMaterial;
    public Material offMaterial;
    [HideInInspector]
    public bool isOn = true;

    void Start()
    {
        light = GetComponent<Light>();
    }

    public void Toggle() {
        if (isOn) {
            light.enabled = false;
            lightObject.GetComponent<Renderer>().material = offMaterial;
            isOn = false;
        } else {
            light.enabled = true;
            lightObject.GetComponent<Renderer>().material = onMaterial;
            isOn = true;
        }
    }
}
