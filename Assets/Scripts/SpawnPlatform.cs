using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SpawnPlatform : MonoBehaviour
{
    public GameObject prefab;

    private void OnEnable()
    {
        GetComponent<XRGrabInteractable>().selectEntered.AddListener(OnGrab);
    }

    private void OnGrab(SelectEnterEventArgs arg0)
    {
        Instantiate(prefab);
    }
}
