using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float valorX;
    [SerializeField] float valorY;
    [SerializeField] float valorZ;
    void Update()
    {
        transform.Rotate(valorX * Time.deltaTime, valorY * Time.deltaTime, valorZ * Time.deltaTime);
    }
}