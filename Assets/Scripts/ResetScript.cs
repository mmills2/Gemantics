using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ResetScript : MonoBehaviour
{
    public GameObject ball;
    public BounceDetection bounceDetection;
    public TextMeshPro winText;

    private void OnEnable()
    {
        GetComponent<XRGrabInteractable>().selectEntered.AddListener(OnGrab);
    }

    private void OnGrab(SelectEnterEventArgs arg0)
    {
        ResetBall();
        bounceDetection.ResetBounces();
        winText.text = "";
    }

    public void ResetBall()
    {
        ball.transform.position = new Vector3(0, (float)1.351, (float)0.521);
        ball.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
    }
}