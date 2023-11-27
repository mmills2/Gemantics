using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR;
using static UnityEditor.Progress;

public class RightController : MonoBehaviour
{
    public InputActionProperty activateInput;

    public GameObject prefab;

    private void OnEnable()
    {
        activateInput.action.started += SpawnAPlatform;
    }
    private void SpawnAPlatform(InputAction.CallbackContext context)
    {
        Instantiate(prefab, gameObject.transform.position, gameObject.transform.rotation);

    }
}
