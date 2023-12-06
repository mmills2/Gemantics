using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateSelectLevel : MonoBehaviour
{
    private bool one = false;
    private bool two = false;
    private bool three = false;

    public GameObject lvl1btn;
    public GameObject lvl2btn;
    public GameObject lvl3btn;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void completeLevel(int level)
    {
        if (level == 1) { one = true; }
        else if (level == 2) { two = true; }
        else if (level == 3) { three = true; }
    }

    public void activateLevels()
    {
        if (one) { lvl1btn.GetComponent<Button>().enabled = true; lvl1btn.SetActive(true); }
        if (two) { lvl2btn.GetComponent<Button>().enabled = true; lvl2btn.SetActive(true); }
        if (three) { lvl3btn.GetComponent<Button>().enabled = true; lvl3btn.SetActive(true); }

    }
}
