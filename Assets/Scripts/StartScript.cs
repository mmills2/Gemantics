using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class StartScript : MonoBehaviour
{
    public GameObject ball;

    private void OnEnable()
    {
        GetComponent<XRGrabInteractable>().selectEntered.AddListener(OnGrab);
    }

    private void OnGrab(SelectEnterEventArgs arg0)
    {
        ball.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
    }
}
