using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class physics_wasd : MonoBehaviour
{
    Physics gravity;
    // Start is called before the first frame update
    void Start()
    {
        gravity = GetComponent<Physics>();
    }

    // Update is called once per frame
    void Update()
    {
       // Physics.gravity = new Vector3(0, gravity, 0);  // gravity= -35 其他的默认
    }


}
