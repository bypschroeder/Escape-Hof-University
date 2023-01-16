using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeypadController : MonoBehaviour
{
    public TextMeshPro inputField;
    public string password;
    private GameObject[] buttons;
    public AudioSource correctSound;
    public AudioSource incorrectSound;

    void Start() {
        buttons = GameObject.FindGameObjectsWithTag("KeypadButton");
    }

    void Update() {
        if (inputField.text.Length == 4) {
            CheckCode();
        }
    }

    public void CheckCode() {
        if (inputField.text == password) {
            Debug.Log("Correct Code");
            inputField.text = "Correct";
            foreach (GameObject button in buttons) {
                KeypadButtonPress script = button.GetComponent<KeypadButtonPress>();
                if (script != null) script.enabled = false;
            }
            correctSound.Play();
        }
        else
        {
            Debug.Log("Incorrect Code");
            inputField.text = "";
            incorrectSound.Play();
        }
    }
}
