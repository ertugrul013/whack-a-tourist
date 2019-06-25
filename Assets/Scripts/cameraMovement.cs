using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    float speed = 1f;
    float angleY;
    float angleZ = 0f;

    void Update()
    {

        //left right
        float xMove = Input.GetAxis("Horizontal") * Time.deltaTime * 10;
        transform.Translate(xMove, 0f, 0f);
        Vector3 clampedPosition = transform.position;

        clampedPosition.x = Mathf.Clamp(clampedPosition.x, -2f, 2f);
        transform.position = clampedPosition;



        //up down
        Vector3 currentRotation = transform.localRotation.eulerAngles;
        currentRotation.x = (currentRotation.x > 180) ? currentRotation.x - 360 : currentRotation.x;
        currentRotation.x = Mathf.Clamp(currentRotation.x, -10, 10);

        float y = transform.rotation.x;
        float v = Input.GetAxis("Vertical");


        transform.localRotation = Quaternion.Euler(currentRotation);

        if (Input.GetKey(KeyCode.W))
        {
            transform.Rotate(y + v * -speed, 0, 0);
           
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Rotate(y + v * -speed,0, 0);
           
        }

        




    }
}
