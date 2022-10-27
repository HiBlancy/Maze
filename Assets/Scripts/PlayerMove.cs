using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{
    float velocidadMovimiento = 10f;

    void Update()
    {
        float valorX = Input.GetAxis("Horizontal") * Time.deltaTime * velocidadMovimiento;
        float valorZ = Input.GetAxis("Vertical") * Time.deltaTime * velocidadMovimiento;
        transform.Translate(valorX * 0.5f, 0, valorZ * 0.5f);

        ReinicioRapido();
        MenuSalir();
    }

    void ReinicioRapido()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Juego");
        }
    }

    void MenuSalir()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("Inicio");
        }
    }
}
