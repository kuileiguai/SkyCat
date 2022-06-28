using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fly : MonoBehaviour
{
    private Animator arin;
    public static string status = "GROUND";
    // Start is called before the first frame update
    void Start()
    {
        arin = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Tab))
        {
            if(status == "GROUND")
            {
                status = "SKY";
            }
            else
            {
                status = "GROUND";
            }
            
        }
    }
}
