using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arms_camera : MonoBehaviour
{
    public Transform target;
    GameObject cat;
    GameObject mac;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        //else
        //{
        //    //transform.right = a_r;
        //    //transform.up = a_u;
        //    transform.forward = a_f;
        //}
    }

    private void FixedUpdate()
    {
        cat = GameObject.Find("CAT");
        mac = GameObject.Find("MAC");

        //a_Rotatio = (transform.position - target.position).normalized;
        float value = Vector3.Dot(mac.transform.forward.normalized, cat.transform.up.normalized);
        if (Input.GetKey(KeyCode.V))
        {
            Debug.Log(value);
            // if (value<0.985f&&value>0)
            // {
                transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(50, 0,0), 0.05f);
            // }
        }
        /*   else
           {
               if (value > 0.5f)
               {
                   transform.Rotate(new Vector3(0, 0, -30f));
               }

           }

        */
    }
}
