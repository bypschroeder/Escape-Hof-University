using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : Interactable
{
    private Socket socket = null;

    private void Awake()
    {
        socket = GetComponent<Socket>();
    }

    public override void StartInteraction(Hand hand)
    {
        Socket handSocket = hand.GetSocket();
        Moveable heldObject = handSocket.GetStoredObject();

        if (heldObject) {
            TryStore(heldObject);
        }
        else {
            TryRetrieve(handSocket);
        }
    }

    public void TryStore(Moveable newMovealbe) {
        if(!socket.GetStoredObject())
            newMovealbe.AttachNewSocket(socket);
    }

    private void TryRetrieve(Socket newSocket) {
        Moveable objectToRetrieve = socket.GetStoredObject();

        if(objectToRetrieve)
            objectToRetrieve.AttachNewSocket(newSocket);
    }
}
