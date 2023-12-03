using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.XR.CoreUtils;
using UnityEngine;

public class LevelGoalScript : MonoBehaviour
{
    //public TextMeshPro winText;
    public GameObject ball;
    public GameObject player;
    public GameObject nextLevel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //winText.text = "YOU WIN";
        ball.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;

        if(nextLevel != null) { nextLevel.SetActive(true); }
    }
}
