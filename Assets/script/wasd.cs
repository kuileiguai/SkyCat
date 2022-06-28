using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;
using System.Net.Sockets;

public class wasd : MonoBehaviour
{
    public int speed = 20;
    public float rotateSeed = 6f;
    private Rigidbody rigid;
    private Vector3 camare_R;
    public GameObject m_tirpod;
    //public float sendcd;//发送速度

    // Start is called before the first frame update
    void Start()
    {
        m_tirpod = GameObject.Find("tripod");
        rigid = GetComponent<Rigidbody>();     
    }

    // Update is called once per frame


    void Update()
    { 
        camare_R = new Vector3(m_tirpod.transform.forward.x, 0, m_tirpod.transform.forward.z).normalized;
        // if(fly.status == "GROUND")
        //{
        G_WASD();
        //sendPosition();
        //}
        //else if(fly.status == "SKY")
        //{
        //    S_WASD();
        //}
        //

    }


    private void FixedUpdate()
    {
        G_WASD();
    }

    void G_WASD()
    {
       // GameObject m_tirpod = GameObject.Find("tripod");
        //camare_R = new Vector3(m_tirpod.transform.forward.x, 0, m_tirpod.transform.forward.z).normalized;

        if (Input.GetKey(KeyCode.Mouse1))
        {
            Vector3 targetDir = Vector3.Slerp(transform.forward, camare_R, 200f * Time.deltaTime);
           transform.rotation = Quaternion.LookRotation(targetDir);
            
        }
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 targetDir = Vector3.Slerp(transform.forward, camare_R, rotateSeed * Time.deltaTime);
            transform.rotation = Quaternion.LookRotation(targetDir);
            _m_w();
        }

        if (Input.GetKey(KeyCode.S))
        {
            if (!Input.GetKey(KeyCode.Mouse1))
            {
                Vector3 targetDir = Vector3.Slerp(transform.forward, -camare_R, rotateSeed * Time.deltaTime);
                transform.rotation = Quaternion.LookRotation(targetDir);
            }
            _m_s();
        }

        if (Input.GetKey(KeyCode.A))
        {
            Vector3 left_R;
            if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S))
            {
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    if (!Input.GetKey(KeyCode.Mouse1))
                    {                        
                            left_R = -new Vector3(m_tirpod.transform.right.x, 0, m_tirpod.transform.right.z).normalized;
                            Vector3 targetDir = Vector3.Slerp(transform.forward, left_R, rotateSeed * Time.deltaTime);
                            transform.rotation = Quaternion.LookRotation(targetDir);
                            rigid.velocity = transform.forward * 3 * speed;                        
                    }
                    else
                    {
                        left_R = -new Vector3(m_tirpod.transform.right.x, 0, m_tirpod.transform.right.z).normalized;
                        rigid.velocity = left_R * 3 * speed;
                    }
                }
                else
                {
                    if (!Input.GetKey(KeyCode.Mouse1))
                    {
                        left_R = -new Vector3(m_tirpod.transform.right.x, 0, m_tirpod.transform.right.z).normalized;
                        Vector3 targetDir = Vector3.Slerp(transform.forward, left_R, rotateSeed * Time.deltaTime);
                        transform.rotation = Quaternion.LookRotation(targetDir);
                        rigid.velocity = transform.forward * 3 * speed;
                    }
                    else
                    {
                        left_R = -new Vector3(m_tirpod.transform.right.x, 0, m_tirpod.transform.right.z).normalized;
                        rigid.velocity = left_R * speed;
                    }

                }
            }
        }

        if (Input.GetKey(KeyCode.D))
        {
            Vector3 right_R;
            if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S))
            {
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    if (!Input.GetKey(KeyCode.Mouse1))
                    {
                        right_R = new Vector3(m_tirpod.transform.right.x, 0, m_tirpod.transform.right.z).normalized;
                        Vector3 targetDir = Vector3.Slerp(transform.forward, right_R, rotateSeed * Time.deltaTime);
                        transform.rotation = Quaternion.LookRotation(targetDir);
                        rigid.velocity = transform.forward * 3 * speed; rigid.velocity = transform.forward * 3 * speed;
                    }
                    else
                    {
                        right_R = new Vector3(m_tirpod.transform.right.x, 0, m_tirpod.transform.right.z).normalized;
                        rigid.velocity = right_R * 3 * speed;
                    }
                }
                else
                {
                    if (!Input.GetKey(KeyCode.Mouse1))
                    {
                        right_R = new Vector3(m_tirpod.transform.right.x, 0, m_tirpod.transform.right.z).normalized;
                        Vector3 targetDir = Vector3.Slerp(transform.forward, right_R, rotateSeed * Time.deltaTime);
                        transform.rotation = Quaternion.LookRotation(targetDir);
                        rigid.velocity = transform.forward * 3 * speed;
                    }
                    else
                    {
                        right_R = new Vector3(m_tirpod.transform.right.x, 0, m_tirpod.transform.right.z).normalized;
                        rigid.velocity = right_R * speed;
                    }

                }
            }
        }

    }

    void _m_w()
    {

        //(x,y,z)--(右,上,前)
        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (Input.GetKey(KeyCode.A))
            {
                //二倍速
                //通过世界空间Y轴与Z轴计算移动方向（矢量计算）
                if (!Input.GetKey(KeyCode.Mouse1))
                {
                    Vector3 WA = transform.forward - transform.right;
                    Vector3 targetDir = Vector3.Slerp(transform.forward, WA, rotateSeed * Time.deltaTime);
                    transform.rotation = Quaternion.LookRotation(targetDir);
                    rigid.velocity = WA * 3 * speed;
                }
                else
                {
                    Vector3 WA = transform.forward - transform.right;
                    rigid.velocity = WA * 3 * speed;
                }

            }
            else if (Input.GetKey(KeyCode.D))
            {
                //通过世界空间Y轴与Z轴计算移动方向（矢量计算）
                if (!Input.GetKey(KeyCode.Mouse1))
                {
                    Vector3 WD = transform.forward + transform.right;
                    Vector3 targetDir = Vector3.Slerp(transform.forward, WD, rotateSeed * Time.deltaTime);
                    transform.rotation = Quaternion.LookRotation(targetDir);
                    rigid.velocity = transform.forward * 3 * speed;
                }
                else
                {
                    Vector3 WD = transform.forward + transform.right;
                    rigid.velocity = WD * 3 * speed;
                }
            }
            else
            {
                rigid.velocity = transform.forward * 3 * speed;
            }
        }

        else
        {
            //一倍速
            if (Input.GetKey(KeyCode.A))
            {
                //通过世界空间Y轴与Z轴计算移动方向（矢量计算）
                if (!Input.GetKey(KeyCode.Mouse1))
                {
                    Vector3 WA = transform.forward - transform.right;
                    Vector3 targetDir = Vector3.Slerp(transform.forward, WA, rotateSeed * Time.deltaTime);
                    transform.rotation = Quaternion.LookRotation(targetDir);
                    rigid.velocity = WA * speed;
                }
                else
                {
                    Vector3 WA = transform.forward - transform.right;
                    rigid.velocity = WA * speed;
                }
            }
            else if (Input.GetKey(KeyCode.D))
            {
                //通过世界空间Y轴与Z轴计算移动方向（矢量计算）
                if (!Input.GetKey(KeyCode.Mouse1))
                {
                    Vector3 WD = transform.forward + transform.right;
                    Vector3 targetDir = Vector3.Slerp(transform.forward, WD, rotateSeed * Time.deltaTime);
                    transform.rotation = Quaternion.LookRotation(targetDir);
                    rigid.velocity = transform.forward * speed;
                }
                else
                {
                    Vector3 WD = transform.forward + transform.right;
                    rigid.velocity = WD * speed;
                }
            }
            else
            {
                rigid.velocity = transform.forward * speed;
            }
        }
    }

    void _m_s()
    {
        //(x,y,z)--(右,上,前)

        if (Input.GetKey(KeyCode.LeftShift))
        {
            if (Input.GetKey(KeyCode.A))
            {
                //大世界时启用
                if (!Input.GetKey(KeyCode.Mouse1))
                {
                    Vector3 SA = transform.forward + transform.right;
                    Vector3 targetDir = Vector3.Slerp(transform.forward, SA, rotateSeed * Time.deltaTime);
                    transform.rotation = Quaternion.LookRotation(targetDir);
                }
                //吃鸡类视角
                else
                {
                    Vector3 SA = -transform.forward - transform.right;
                    rigid.velocity = SA * 3 * speed;
                }
            }
            else if (Input.GetKey(KeyCode.D))
            {
                if (!Input.GetKey(KeyCode.Mouse1))
                {
                    Vector3 SD = transform.forward - transform.right;
                    Vector3 targetDir = Vector3.Slerp(transform.forward, SD, rotateSeed * Time.deltaTime);
                    transform.rotation = Quaternion.LookRotation(targetDir);
                }
                else
                {
                    Vector3 SD = -transform.forward + transform.right;
                    rigid.velocity = SD * 3 * speed;
                }
            }
            else
            {
                if (!Input.GetKey(KeyCode.Mouse1))
                {
                    rigid.velocity = transform.forward * 3 *speed;
                }
                else
                {
                    rigid.velocity = -transform.forward * 3 * speed;
                }
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.A))
            {
                if (!Input.GetKey(KeyCode.Mouse1))
                {
                    Vector3 SA = transform.forward + transform.right;
                    Vector3 targetDir = Vector3.Slerp(transform.forward, SA, rotateSeed * Time.deltaTime);
                    transform.rotation = Quaternion.LookRotation(targetDir);
                }
                else
                {
                    Vector3 SA = -transform.forward - transform.right;
                    rigid.velocity = SA * speed;
                }

            }
            else if (Input.GetKey(KeyCode.D))
            {
                if (!Input.GetKey(KeyCode.Mouse1))
                {
                    Vector3 SD = transform.forward - transform.right;
                    Vector3 targetDir = Vector3.Slerp(transform.forward, SD, rotateSeed * Time.deltaTime);
                    transform.rotation = Quaternion.LookRotation(targetDir);
                }
                else
                {
                    Vector3 SD = -transform.forward + transform.right;
                    rigid.velocity = SD * speed;
                }

            }
            else
            {
                if (!Input.GetKey(KeyCode.Mouse1))
                {
                    rigid.velocity = transform.forward * speed;
                }
                else
                {
                    rigid.velocity = -transform.forward * speed;
                }

            }
        }
    }


    void S_WASD()
    {

        GameObject m_tirpod = GameObject.Find("tripod");

        if (Input.GetKey(KeyCode.Alpha8))
        {
            transform.forward = m_tirpod.transform.forward;
            transform.right = m_tirpod.transform.right;
            gameObject.transform.Translate(0, speed * Time.deltaTime, 0, Space.Self);
        }
    }

   // float ntime = 0;
   // void sendPosition()
   // {
   //     ntime += Time.deltaTime;
   //     if(ntime > sendcd)
   //     {
   //         PlayerInfo p = new PlayerInfo(gameObject.name, transform.position);
   //         CatCilent.sendMessage(new Message("ashdbjha", JsonConvert.SerializeObject(p)));
   //     }
   //
   // }
}