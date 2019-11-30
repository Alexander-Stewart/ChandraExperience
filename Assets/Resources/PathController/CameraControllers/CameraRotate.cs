using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    public float speedX = 2.0f;
    public float speedY = 2.0f;
    private float rotateX = 0.0f;
    private float rotateY = 0.0f; 


    // Update is called once per frame
    void Update()
    {
        rotateX += speedX * Input.GetAxis("MouseX");
        rotateY += speedY * Input.GetAxis("MouseY");

        //transform.eulerAngles = new Vector3(rotateX, rotateY, 0.0f);
        transform.Rotate(0, 0, rotateY); 

    }
}
