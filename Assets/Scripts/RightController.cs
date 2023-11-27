using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR;
using static UnityEditor.Progress;
using UnityEngine.XR.Interaction.Toolkit;

public class RightController : MonoBehaviour
{
    public InputActionProperty primaryButton;
    public InputActionProperty secondaryButton;

    public XRRayInteractor rayInteractor;

    public GameObject prefab;
    public XRBaseInteractable heldObject;

    private void OnEnable()
    {
        primaryButton.action.started += SpawnAPlatform;
        secondaryButton.action.started += DeletePlatform;

        rayInteractor = GetComponent<XRRayInteractor>();
        rayInteractor.selectEntered.AddListener(SelectEntered);
        rayInteractor.selectExited.AddListener(SelectExited);

    }

    private void SelectEntered(SelectEnterEventArgs arg0)
    {
        heldObject = (XRBaseInteractable)arg0.interactableObject;
    }
    private void SelectExited(SelectExitEventArgs arg0)
    {
        heldObject = null;
    }

    private void SpawnAPlatform(InputAction.CallbackContext context)
    {
        Instantiate(prefab, gameObject.transform.position, gameObject.transform.rotation);
    }

    private void DeletePlatform(InputAction.CallbackContext context)
    {
        if (heldObject.tag == "Platform")
        {
            Destroy(heldObject.gameObject);
        }
    }

    
}
