using System.Collections;
using System.Collections.Generic;
using System.IO;
using System;
using UnityEngine;

public class Camera_with_mouse : MonoBehaviour
{
    GameObject player = GameObject.Find("Player");
    float x = 0;
    float y = 0;
    float z = 0;

    // Start is clled before the first frame update
    void Start()
    {
        x = player.transform.position.x;
        y = player.transform.position.y;
        z = player.transform.position.z;

        Debug.Log(x);
        Debug.Log(y);
        Debug.Log(z);

        //gameObject.transform.TransformVector(x, y + 6, z - 20);
        //gameObject.transform.Rotate(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        x = player.transform.position.x;
        y = player.transform.position.y;
        z = player.transform.position.z;

        Debug.Log(x);
        Debug.Log(y);
        Debug.Log(z);

        //gameObject.transform.TransformVector(x, y + 6, z - 20);
        //gameObject.transform.Rotate(0, 0, 0);
    }


}
