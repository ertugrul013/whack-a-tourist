using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    float speed = 1f;


    void Update()
    { 
        transform.Rotate(-Input.GetAxis("Mouse Y"),0,0 * -Time.deltaTime * speed);

        float minRotation = 10;
        float maxRotation = 30;
        Vector3 currentRotation = transform.localRotation.eulerAngles;
        currentRotation.x = Mathf.Clamp(currentRotation.x, minRotation, maxRotation);
        transform.localRotation = Quaternion.Euler(currentRotation);


        ////left right
        //float xMove = Input.GetAxis("Horizontal") * Time.deltaTime * 10;
        //transform.Translate(xMove,0f, 0f);   
        //Vector3 clampedPosition = transform.position; 
        //clampedPosition.x = Mathf.Clamp(clampedPosition.x, -2f, 2f);
        //transform.position = clampedPosition;




    }
}
