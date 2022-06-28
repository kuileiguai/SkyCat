using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eye : MonoBehaviour
{
    private float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 100f; //移动速度
       // GameObject thecat = GameObject.Find("CAT");
       // float x = thecat.transform.position.x;
       // float y = thecat.transform.position.y;
       // float z = thecat.transform.position.z;
       // transform.position = new Vector3(x, y + 25f, z);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject thecat = GameObject.Find("CAT");
        float x = thecat.transform.position.x;
        float y = thecat.transform.position.y;
        float z = thecat.transform.position.z;
        transform.position = new Vector3(x, y + 25f , z);

        Vector3 angle = Vector3.zero;
        angle.x = transform.localEulerAngles.x - Input.GetAxis("Mouse Y") * 3 * moveSpeed * Time.deltaTime;
       //if( 180 <=angle.x && angle.x < 350)
       //{
       //    angle.x = 350;
       //}
       //else
        if(20 < angle.x && angle.x < 180)
        {
            angle.x = 20;
        }
        angle.y = transform.localEulerAngles.y + Input.GetAxis("Mouse X") *2* moveSpeed * Time.deltaTime;
        transform.localEulerAngles = angle;

    }


}
