using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grotaion : MonoBehaviour
{
    //private GameObject jizhun;
    // Start is called before the first frame update
     
    void Start()
    {
      
    }  

    // Update is called once per frame
    void Update()
    {
        GameObject gg = GameObject.Find("tripod/zhunxing");
        GameObject jizhun = GameObject.Find("CAT/Bip001/Bip001 Pelvis/Bip001 Spine/Bip001 Neck/Bip001 R Clavicle/Bip001 R UpperArm/Bip001 R Forearm/Bip001 R Hand/mac_gun/jizhun");
        if (Input.GetKey(KeyCode.Mouse1))
        {

            //transform.localRotation = Quaternion.Euler(0, jizhun.transform.localRotation.y, 0);

            //Vector3 dir = (gg.transform.position - transform.position).normalized;
            //dir.z = 0;
            transform.rotation = gg.transform.rotation;
            //transform.up = gg.transform.right.normalized;
           // transform.right = gg.transform.forward.normalized;
            //transform.up = gg.transform.right.normalized;
            //float x = jizhun.transform.localPosition.x;
            //float y = jizhun.transform.localPosition.y;
            //float z = jizhun.transform.localPosition.z;
            //transform.localPosition = new Vector3(x, y, z);


        }
        else if (!Input.GetKeyUp(KeyCode.Mouse1))
        {
           float x = jizhun.transform.localPosition.x;
           float y = jizhun.transform.localPosition.y;
           float z = jizhun.transform.localPosition.z;
           transform.localPosition = new Vector3(x, y, z);
           transform.localRotation = jizhun.transform.localRotation;
        }

    }


}
