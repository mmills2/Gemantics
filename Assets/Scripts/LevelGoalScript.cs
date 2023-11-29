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
        player.GetComponent<XROrigin>().MoveCameraToWorldLocation(new Vector3(0, player.GetComponent<XROrigin>().Camera.transform.position.y, 25));
        ball.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
    }
}
