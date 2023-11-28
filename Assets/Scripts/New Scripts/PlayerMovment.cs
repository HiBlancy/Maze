using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovment : MonoBehaviour
{
    float velocidadMovimiento = 10f;
    void Update()
    {
        float valorX = Input.GetAxis("Horizontal") * Time.deltaTime * velocidadMovimiento;
        float valorZ = Input.GetAxis("Vertical") * Time.deltaTime * velocidadMovimiento;
        transform.Translate(valorX * 0.5f, 0, valorZ * 0.5f);
    }
}