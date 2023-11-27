using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelGoalScript : MonoBehaviour
{
    //public TextMeshPro winText;
    public GameObject ball;

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
    }
}
