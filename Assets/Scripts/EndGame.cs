using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    // public int counter = 0;
    public GameObject UIEndGame;
   
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "balls" || collision.gameObject.tag == "ballball")
        {
            collision.gameObject.SetActive(false);
            UIEndGame.SetActive(true);
        }
    }

  
}
