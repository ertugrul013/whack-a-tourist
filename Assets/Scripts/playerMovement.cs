﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public GameObject coco;
    

    public int aantalCoco = 5;

    void Update()
    {
        if (aantalCoco > 0)
        {
          
            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(coco, Camera.main.transform.position + (transform.forward * 2), Camera.main.transform.rotation);
                aantalCoco--;
            }
        }
    }


}
