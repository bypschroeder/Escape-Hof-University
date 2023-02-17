using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Camera camera;
    public RenderTexture renderTexture;
    public GameObject softbox;
    public GameObject ledLight;
    public GameObject ceilingLight;
    public GameObject blind;
    public GameObject vrHeadset;
    public GameObject vrHeadsetCollider;
    public GameObject vrControllerL;
    public GameObject vrControllerLCollider;
    public GameObject vrControllerR;
    public GameObject vrControllerRCollider;
    public GameObject hat;
    public GameObject hatCollider;
    public GameObject umbrella;
    public GameObject umbrellaCollider;
    public GameObject mask;
    public GameObject maskColider;
    public GameObject knife;
    public GameObject knifeCollider;
    public GameObject helmet;
    public GameObject helmetCollider;
    public GameObject baseballBat;
    public GameObject baseballBatCollider;
    public GameObject tvScreen;
    public Material tvScreen1Material;
    public Material tvScreen2Material;
    public Material tvScreen3Material;
    public Material tvScreen4Material;
    public GameObject photo1;
    public GameObject photo2;
    public GameObject photo3;
    public GameObject photo4;
    private bool isPhoto1Taken = false;
    private bool isPhoto2Taken = false;
    private bool isPhoto3Taken = false;
    private bool isPhoto4Taken = false;
    public AudioSource shutterSound;


    public void takePhoto() {
        if (
            softbox.GetComponent<ToggleLight>().isOn
            && ledLight.GetComponent<ToggleLight>().isOn
            && !ceilingLight.GetComponent<ToggleLight>().isOn 
            && !blind.GetComponent<OpenCloseBlind>().isOpen 
            && vrHeadsetCollider.GetComponent<SnapZone>().isSnapped 
            && vrControllerLCollider.GetComponent<SnapZone>().isSnapped 
            && vrControllerRCollider.GetComponent<SnapZone>().isSnapped
            && !isPhoto1Taken
            ) {
                tvScreen.SetActive(true);
                tvScreen.GetComponent<Renderer>().material = tvScreen1Material;
                shutterSound.Play();
                isPhoto1Taken = true;
                vrHeadset.SetActive(false);
                vrControllerL.SetActive(false);
                vrControllerR.SetActive(false);
                photo1.SetActive(true);
        } 
        else if (
            softbox.GetComponent<ToggleLight>().isOn
            && ledLight.GetComponent<ToggleLight>().isOn
            && !ceilingLight.GetComponent<ToggleLight>().isOn 
            && !blind.GetComponent<OpenCloseBlind>().isOpen 
            && hatCollider.GetComponent<SnapZone>().isSnapped 
            && umbrellaCollider.GetComponent<SnapZone>().isSnapped 
            && !isPhoto2Taken
            ) {
                tvScreen.SetActive(true);
                tvScreen.GetComponent<Renderer>().material = tvScreen2Material;
                shutterSound.Play();
                isPhoto2Taken = true;
                hat.SetActive(false);
                umbrella.SetActive(false);
                photo2.SetActive(true);
        }
        else if (
            softbox.GetComponent<ToggleLight>().isOn
            && ledLight.GetComponent<ToggleLight>().isOn
            && !ceilingLight.GetComponent<ToggleLight>().isOn 
            && !blind.GetComponent<OpenCloseBlind>().isOpen 
            && maskColider.GetComponent<SnapZone>().isSnapped 
            && knifeCollider.GetComponent<SnapZone>().isSnapped 
            && !isPhoto3Taken
            ) {
                tvScreen.SetActive(true);
                tvScreen.GetComponent<Renderer>().material = tvScreen3Material;
                shutterSound.Play();
                isPhoto3Taken = true;
                mask.SetActive(false);
                knife.SetActive(false);
                photo3.SetActive(true);
        }
        else if (
            softbox.GetComponent<ToggleLight>().isOn
            && ledLight.GetComponent<ToggleLight>().isOn
            && !ceilingLight.GetComponent<ToggleLight>().isOn 
            && !blind.GetComponent<OpenCloseBlind>().isOpen 
            && helmetCollider.GetComponent<SnapZone>().isSnapped 
            && baseballBatCollider.GetComponent<SnapZone>().isSnapped 
            && !isPhoto4Taken
            ) {
                tvScreen.SetActive(true);
                tvScreen.GetComponent<Renderer>().material = tvScreen4Material;
                shutterSound.Play();
                isPhoto4Taken = true;
                helmet.SetActive(false);
                baseballBat.SetActive(false);
                photo4.SetActive(true);
        }
    }
}

