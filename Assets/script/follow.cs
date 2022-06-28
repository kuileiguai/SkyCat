using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class follow : MonoBehaviour
{
    
    public float moveSpeed;
    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 50f; //移动速度
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 angle = Vector3.zero;
        //angle.x = transform.localEulerAngles.x;
        angle.y = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * moveSpeed * Time.deltaTime;
        transform.localEulerAngles = angle;

    }
}
