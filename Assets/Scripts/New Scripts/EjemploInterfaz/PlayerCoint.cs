using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCoint : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        ICollectible collectible = other.GetComponent<ICollectible>();

        if (collectible != null)
            collectible.Collect();
    }
}