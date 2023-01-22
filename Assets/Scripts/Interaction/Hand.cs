using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class Hand : MonoBehaviour
{
    private Socket socket = null;
    private SteamVR_Behaviour_Pose pose = null;

    public List<Interactable> contactInteractables = new List<Interactable>();

    private void Awake()
    {
        socket = GetComponent<Socket>();
        pose = GetComponent<SteamVR_Behaviour_Pose>();
    }

    private void OnTriggerEnter(Collider other) {
        AddInteractable(other.gameObject);
    }

    private void AddInteractable(GameObject gameObject) {
        Interactable newInteractable = gameObject.GetComponent<Interactable>();
        contactInteractables.Add(newInteractable);
    }

    private void OnTriggerExit(Collider other) {
        RemoveInteractable(other.gameObject);
    }

    private void RemoveInteractable(GameObject gameObject) {
        Interactable existingInteractable = gameObject.GetComponent<Interactable>();
        contactInteractables.Remove(existingInteractable);
    }

    public void TryInteraction() {
        if (NearestInteraction())
            return;

        HeldInteraction();
    }

    private bool NearestInteraction() {
        Interactable nearestObject = Utility.GetNearestInteractable(transform.position, contactInteractables);

        if (nearestObject)
            nearestObject.StartInteraction(this);

        return nearestObject;
    }

    private void HeldInteraction() { 
        Moveable heldObject = socket.GetStoredObject();

        if (heldObject) 
            heldObject.Interaction(this);
    }

    private void StopInteraction() { 
        Moveable heldObject = socket.GetStoredObject();

        if (heldObject) 
            heldObject.EndInteraction(this);
    }

    public Socket GetSocket() {
        return socket;
    }

    public SteamVR_Behaviour_Pose GetPose() {
        return pose;
    }
}