using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWithObstacles : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        if (!other.gameObject.CompareTag("Suelo") && !other.gameObject.CompareTag("Finishh"))
            ScoreManager.obj.UpdateScoreG();
    }
}