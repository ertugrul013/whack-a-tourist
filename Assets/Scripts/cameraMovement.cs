using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{
    float speed = 1f;


    void Update()
    { 
        transform.Rotate(-Input.GetAxis("Mouse Y"),0,0 * -Time.deltaTime * speed);

        //if (transform.position.x < 2 && transform.position.x > -2)
        //{
        //    this.transform.Translate(Input.GetAxis("Horizontal"), 0, 0);
        //}

        float xMove = Input.GetAxis("Horizontal") * Time.deltaTime * 10;

        transform.Translate(xMove,0f, 0f);
   
        Vector3 clampedPosition = transform.position;
  
        clampedPosition.x = Mathf.Clamp(clampedPosition.x, -2f, 2f);

        transform.position = clampedPosition;




    }
}
