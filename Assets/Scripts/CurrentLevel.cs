using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentLevel : MonoBehaviour
{
    public int level;

    // Start is called before the first frame update
    void Start()
    {
        level = 1;
    }
    
    public void setLevel(int setLevel)
    {
        level = setLevel;
    }

    public Vector3 getResetCords() { 
        if(level == 1)
        {
            return new Vector3(0, (float)1.351, (float)0.521);
        }
        else if (level == 2)
        {
            return new Vector3(1, (float)1.351, (float)0.521);
        }
        else if (level == 3)
        {
            return new Vector3(2, (float)1.351, (float)0.521);
        }
        else
        {
            return new Vector3(0, 0, 0);
        }
    }
}
