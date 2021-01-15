using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class Roulette_C : MonoBehaviour
{
    float angle = 0.0f;
    Boolean isRotate = true;

    // Start is called before the first frame update
    void Start()
    {
    }

    //! あとで関数化する

    // Update is called once per frame
    void Update()
    {
        if (isRotate)
        {
            //! Tutorial
            if (Input.GetMouseButtonDown(0))
            {
                angle = 10.0f;
            }
            transform.Rotate(new Vector3(0, 0, angle));
            angle *= 0.997f;

            // If not m-lab -> Don' stop
             float rotateZ = transform.localRotation.z;
            // float rotateZ = transform.rotation.localEulerAngles.z;
            if ((angle != 0.0f && angle < 0.3f) &&  (rotateZ > -3.0/4 && rotateZ < 3.0/4))
             {
                angle = 0.3f;
                Debug.Log(rotateZ);
             }

            //Quaternion quaternion = this.transform.rotation;
            //Debug.Log(quaternion);
            //float z = quaternion.eulerAngles.z;
            //Debug.Log(z);

            //if (rotateZ > 185.0f || rotateZ < 190.0f)
            //{
            //   isRotate = false;
            //}
        }
    }
}
