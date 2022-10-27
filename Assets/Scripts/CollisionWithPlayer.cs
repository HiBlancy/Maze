using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWithPlayer : MonoBehaviour
{
    void OnCollisionEnter (Collision other)
    {
        if(other.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
        }

    }

    void OnTriggerEnter (Collider others)
    {
        if(others.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
        }

    }
}
