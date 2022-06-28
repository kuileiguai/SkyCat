using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttermove : MonoBehaviour
{
    private float M = 800;
    public float speed = 15f;
    Vector3 temp;
    // Start is called before the first frame update
    void Start()
    {
        temp = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        
      // if ((transform.position - temp).magnitude > M)
      // {
      //     Destroy(gameObject);
      // }
    }

    private void FixedUpdate()
    {
        if (gameObject.name != "butter")
        {
            transform.position += transform.forward * Time.deltaTime * speed;
        }
        
       if ((transform.position - temp).magnitude > M && gameObject.name!="butter")
       {
           Destroy(gameObject);
       }
       // Debug.Log(gameObject);
    }
}
