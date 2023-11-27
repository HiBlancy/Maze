using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWithCoints : MonoBehaviour
{
    void OnTriggerEnter(Collider others)
    {
        if (others.gameObject.CompareTag("Moneda"))
        {
            ScoreManager.obj.UpdateScoreM();
            Destroy(others.gameObject);
        }
    }
}