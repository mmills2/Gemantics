using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;

public class CurrentLevel : MonoBehaviour
{
    public int level;
    public GameObject player;
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        setLevel(level);
    }
    
    public void setLevel(int setLevel)
    {
        level = setLevel;
        player.GetComponent<XROrigin>().MoveCameraToWorldLocation(getPlayerCords());
        ball.transform.position = getResetCords();
    }

    public Vector3 getResetCords() { 
        if(level == 1)
        {
            return new Vector3(0, (float)1.351, (float)0.521);
        }
        else if (level == 2)
        {
            return new Vector3(0, (float)1.351, (float)-4.589);
        }
        else if (level == 3)
        {
            return new Vector3(0, (float)1.351, (float)0.521);
        }
        else
        {
            return new Vector3(0, 0, 0);
        }
    }

    public Vector3 getPlayerCords()
    {
        if (level == 1)
        {
            return new Vector3(0, player.GetComponent<XROrigin>().Camera.transform.position.y, 0);
        }
        else if (level == 2)
        {
            return new Vector3(0, player.GetComponent<XROrigin>().Camera.transform.position.y, (float)-5.11);
        }
        else if (level == 3)
        {
            return new Vector3(2, player.GetComponent<XROrigin>().Camera.transform.position.y, (float)0.521);
        }
        else
        {
            return new Vector3(0, 0, 0);
        }
    }
}
