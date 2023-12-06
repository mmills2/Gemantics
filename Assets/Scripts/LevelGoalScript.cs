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
    public GameObject levelSelect;
    public GameObject levelSelectMenu;
    public int level;

    private void OnTriggerEnter(Collider other)
    {
        //if (other.tag == "Ball")
        //{
            //winText.text = "YOU WIN";
            other.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            if (levelSelectMenu != null) { levelSelectMenu.SetActive(true); }
            if (nextLevel != null) { nextLevel.SetActive(true); }
            levelSelect.GetComponent<ActivateSelectLevel>().completeLevel(level);
        //}
    }
}
