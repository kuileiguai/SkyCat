using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class butterCollisionEnter : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.collider.name);
        Destroy(gameObject);    
    }
}
