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

    private bool reset = true;

    private void OnEnable()
    {
        primaryButton.action.started += StartBall;
        secondaryButton.action.started += ResetBall;
    }

    private void StartBall(InputAction.CallbackContext context)
    {
        if (reset) {
            reset = false;
            ball.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            if (currentLevel.GetComponent<CurrentLevel>().getNoGravity())
            {
                ball.GetComponent<Rigidbody>().AddForce(Vector3.down * 3f, ForceMode.VelocityChange);
            }
        }
    }

    private void ResetBall(InputAction.CallbackContext context)
    {
        resetBall();
    }

    public void resetBall()
    {
        reset = true;
        ball.transform.position = currentLevel.GetComponent<CurrentLevel>().getResetCords();
        ball.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
    }
}
