using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraFollow : MonoBehaviour
{
    public Camera camera;
    //public Transform balls;
    float moveAmount = 2f;
    float edgeSize= 200f;

    private void FixedUpdate()
    {
        //camera.transform.position = new Vector3(5.11f, balls.position.y, 9.44f);
        if (Input.GetMouseButton(0))
        {
            if (Input.mousePosition.y < edgeSize)
            {
                camera.transform.position = new Vector3(5.11f, camera.transform.position.y - moveAmount * Time.deltaTime, 19.43f);

            }
        }
        
    }
}
