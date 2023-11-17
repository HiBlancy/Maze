using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionFinish : MonoBehaviour
{
    [SerializeField] GameObject camaraGO;
    void OnTriggerEnter(Collider others)
    {
        if (others.gameObject.CompareTag("Finishh"))
        {
            camaraGO.SetActive(true);
        }
    }
}
