using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coint : MonoBehaviour, ICollectible
{
    public void Collect()
    {
        ScoreManager.obj.UpdateScoreM();
    }
}