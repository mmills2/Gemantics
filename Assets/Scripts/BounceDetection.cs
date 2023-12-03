using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BounceDetection : MonoBehaviour
{
    public int bounces = 0;
    //public TextMeshPro bounceText;
    //public ResetScript resetScript;
    public GameObject currentLevel;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            bounces++;
            //bounceText.text = "Bounces: " + bounces.ToString("#");
        }
        else if (collision.gameObject.tag == "Obstacle")
        {
            ResetBounces();
            //resetScript.ResetBall();
            transform.position = currentLevel.GetComponent<CurrentLevel>().getResetCords();
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        }
    }

    public void ResetBounces()
    {
        bounces = 0;
        //bounceText.text = "Bounces: 0";
    }
}
