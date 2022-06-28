using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robotcontroller : MonoBehaviour
{
    public GameObject bullet;
    public Transform fire;
    public Transform shooterPoint;
    public int range = 800;
    public int currentBullects;
    private bool GunShootInput;
    private float fireRate = 0.5f;//����
    private float fireTimer;//��ʱ
    private GameObject player;
    public GameObject robot;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("CAT");
    }

    // Update is called once per frame
    void Update()
    {
        if (Moveone.flag)
        {
            //robotFire();
            if(robot != null)
            {
                Vector3 temp = (player.transform.position - robot.transform.position).normalized;
                if (Vector3.Angle(robot.transform.forward, temp) < 10f)//�����ǰ����������Ҽн�С��ʮ�������ӵ�
                {
                    //Debug.Log("1111");
                    robotFire();

                    if (fireTimer < fireRate)
                    {
                        fireTimer += Time.deltaTime;
                    }
                }
            }

        }
    }

    public void robotFire()
    {
        //�������٣����ʱ��������ֵС�������������
        if (fireTimer < fireRate)
        {
            return;
        }
        fire.transform.LookAt(player.transform.position);
        Instantiate(bullet, fire.position, fire.rotation);
        fireTimer = 0f;
    }
}
