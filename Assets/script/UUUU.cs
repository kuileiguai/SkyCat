using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UUUU : MonoBehaviour
{
    private Animator arin;
    // Start is called before the first frame update
    void Start()
    {
        arin = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.Mouse1))
        {
            arin.SetBool("isAiming", true);
        }
        else
        {
            arin.SetBool("isAiming", false);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            arin.SetBool("walk", true);
        }

        if (!Input.GetKey(KeyCode.S)&&!Input.GetKey(KeyCode.W)&&!Input.GetKey(KeyCode.A)&&!Input.GetKey(KeyCode.D))
        {
            arin.SetBool("walk", false);
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            arin.SetBool("run", true);
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            arin.SetBool("run", false);
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            arin.SetBool("T_jump", true);
        }

      
    }


}
