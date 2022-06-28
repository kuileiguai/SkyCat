using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_change : MonoBehaviour
{
    public Camera ca1;
    public Camera ca2;
    // Start is called before the first frame update
    void Start()
    {
        ca1.enabled = true;
        ca2.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse1))
        {
            ca1.enabled = false;
            ca2.enabled = true;
        }
        else
        {
            ca1.enabled = true;
            ca2.enabled = false;
        }
    }
}
