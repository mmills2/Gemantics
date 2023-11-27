using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR;
using static UnityEditor.Progress;

public class LeftController : MonoBehaviour
{
    public InputActionProperty primaryButton;
    public InputActionProperty secondaryButton;

    public GameObject ball;
    public GameObject currentLevel;

    private void OnEnable()
    {
        primaryButton.action.started += StartBall;
        secondaryButton.action.started += ResetBall;
    }

    private void StartBall(InputAction.CallbackContext context)
    {
        ball.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
    }

    private void ResetBall(InputAction.CallbackContext context)
    {
        ball.transform.position = currentLevel.GetComponent<CurrentLevel>().getResetCords();
        ball.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
    }
}
