using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class robotbutterMove : MonoBehaviour
{
    private float M = 1000;
    public float speed = 10f;
    Vector3 temp;
    // Start is called before the first frame update
    void Start()
    {
        temp = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void FixedUpdate()
    {
        if (gameObject.name != "butter1")
        {
            transform.position += transform.forward * Time.deltaTime * speed;
        }

        if ((transform.position - temp).magnitude > M && gameObject.name != "butter1")
        {
            Destroy(gameObject);
        }
         Debug.Log(gameObject.name);
    }
}
