using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moveone : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody robotrig;
    private GameObject Rplayer;
    public static bool flag = false;
    public int Bloodvolume = 10;
    private float speed = 10f;

        private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "butter(Clone)")
        {
            Bloodvolume = Bloodvolume - 1;
        }
        //Debug.Log(collision.collider.name);
    }
        public void OnTriggerEnter(Collider other)
    {
        //碰撞体进入
        //Debug.Log(other.gameObject.name);
        if (other.gameObject.name == "CAT")
        {
            flag = true;
            Rplayer = other.gameObject;
        }
    }

    public void OnTriggerStay(Collider other)
    {
        //碰撞体停留
        //碰撞体进入
        //Debug.Log(other.gameObject.name);
        if (other.gameObject.name == "CAT")
        {
            flag = true;
            Rplayer = other.gameObject;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        //碰撞体离开
        flag = false;
    }
    void Start()
    {
        robotrig = GetComponent<Rigidbody>();       
    }

     //Update is called once per frame
     void Update()
    {
        //Debug.Log(flag);
        if(flag == true)
        {
            if (Rplayer != null)
            {
                Vector3 robot_R = (Rplayer.gameObject.transform.position - transform.position).normalized;
                Vector3 targetDir = Vector3.Slerp(transform.forward, robot_R, 1f * Time.deltaTime);
                transform.rotation = Quaternion.LookRotation(targetDir);
                gameObject.transform.Translate(0, 0, speed * Time.deltaTime, Space.Self);
            }

        }
        if (Bloodvolume <= 0)
        {
            Destroy(gameObject);
        }
        
    }
}
