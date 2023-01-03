using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class SpawnOnClick : MonoBehaviour

{

    public SteamVR_Action_Boolean spawnAction = null;

    public GameObject prefabToSpawn;

    public Transform spawnPoint;

    private void Awake()

    {

        spawnAction.AddOnStateDownListener(TriggerDown, SteamVR_Input_Sources.Any);

    }

    private void TriggerDown(SteamVR_Action_Boolean fromAction, SteamVR_Input_Sources fromSource)

    {

        Instantiate(prefabToSpawn, spawnPoint.position, spawnPoint.rotation);

    }

}
