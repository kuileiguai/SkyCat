using Microsoft.Unity.VisualStudio.Editor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controller : MonoBehaviour
{
    public GameObject bullet;
    public Transform fire;
    public Transform shooterPoint;
    public int builetsMag = 31;
    public int range = 800;
    public int bulletLeft = 300;
    public int currentBullects;
    private bool GunShootInput;

    private float fireRate = 0.1f;//����
    private float fireTimer;//��ʱ
    [Header("��������")]
    public KeyCode reloadInputName;


    [Header("UI����")]
    public UnityEngine.UI.Image CrossHairUI;
    public Text AmmoTextUI;
    // Start is called before the first frame update
    void Start()
    {
        reloadInputName = KeyCode.R;
        currentBullects = builetsMag;
        updateUI();
    }

    // Update is called once per frame
    void Update()
    {
        GunShootInput = Input.GetMouseButton(0);
        if (Input.GetKeyDown(reloadInputName) && currentBullects < builetsMag&&bulletLeft>0)
        {
            Reload();
        }
        if (GunShootInput)
        {
            GunFire();
        }

        if(fireTimer < fireRate)
        {
            fireTimer += Time.deltaTime;
        }
    }

    public void GunFire()
    {
        //�������٣����ʱ��������ֵС�������������
        if(fireTimer < fireRate|| currentBullects<=0)
        {
            return;
        }
        Instantiate(bullet, fire.position, fire.rotation);
        currentBullects--;
        updateUI();
        fireTimer = 0f;
    }

    public void updateUI()
    {
        AmmoTextUI.text = currentBullects + "/" + bulletLeft;
    }

    public void Reload()
    {
        if(bulletLeft <= 0)
        {
            return;
        }
        int bulletload = builetsMag - currentBullects;//����װ�ӵ���
        if (bulletload < 0)
        {
            bulletLeft = 0;
            currentBullects += bulletload;
        }
        else
        {
            bulletLeft = bulletLeft - bulletload;
            currentBullects = builetsMag;
        }

        updateUI();
    }
}
