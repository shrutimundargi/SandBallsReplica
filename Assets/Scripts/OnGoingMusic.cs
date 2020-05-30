using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnGoingMusic : MonoBehaviour
{
    static OnGoingMusic instance = null;
    private void Awake()
    {

        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(transform.gameObject);
        }
    }
}

