using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeypadButtonPress : MonoBehaviour
{
    public TextMeshPro inputField;
    public string letter;
    private AudioSource buttonPressedSound;

    void Start() {
        buttonPressedSound = GetComponent<AudioSource>();
    }

    public void AddLetter() {
        if (enabled) {
            inputField.text += letter;
            buttonPressedSound.Play();
        }
    }
}
