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


        //  transform.Rotate(-Input.GetAxis("Mouse Y"), 0, 0 * -Time.deltaTime * speed);

        //  Vector3 currentRotation = transform.localRotation.eulerAngles;
        //  currentRotation.x = Mathf.Clamp(currentRotation.x, 1, 10);

        //  //transform.Rotate(0, Input.GetAxis("Mouse X"), 0 * -Time.deltaTime * speed);
        //  //currentRotation = transform.localRotation.eulerAngles;
        //  //angleY = transform.rotation.eulerAngles.y;

        //  //if (angleY > 10 || angleY < 270)
        //  //{
        //  //    angleY = 10;
        //  //}
        //  //else if (angleY < -10 || angleY > -270)
        //  //{
        //  //    angleY = -10;
        //  //}

        //  //angleZ = transform.rotation.eulerAngles.z;

        //  //currentRotation.y = Mathf.Clamp(currentRotation.y, -360, 10);


        //transform.localRotation = Quaternion.Euler(currentRotation);







        //left right
        float xMove = Input.GetAxis("Horizontal") * Time.deltaTime * 10;
        transform.Translate(xMove, 0f, 0f);
        Vector3 clampedPosition = transform.position;
        clampedPosition.x = Mathf.Clamp(clampedPosition.x, -2f, 2f);
        transform.position = clampedPosition;

        //up down 
        float YMove = Input.GetAxis("Vertical") * Time.deltaTime * 10;
        transform.Translate(0f, YMove, 0f);
        Vector3 clampedPositionY = transform.position;
        clampedPositionY.y = Mathf.Clamp(clampedPositionY.y, 1f, 3f);
        transform.position = clampedPositionY;



    }
}
