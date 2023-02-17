using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class KeypadController : MonoBehaviour
{
    public TextMeshPro inputField;
    public string password;
    public UnityEvent onCorrectCode;
    private GameObject[] buttons;
    public AudioSource correctSound;
    public AudioSource incorrectSound;
    public string buttonTag;

    void Start() {
        buttons = GameObject.FindGameObjectsWithTag(buttonTag);
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
            onCorrectCode.Invoke();
        }
        else
        {
            Debug.Log("Incorrect Code");
            inputField.text = "";
            incorrectSound.Play();
        }
    }
}
