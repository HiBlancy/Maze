using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagers : MonoBehaviour
{
    public void PlayPressed()
    {
        SceneManager.LoadScene("Juego");
    }

    public void MenuPressed()
    {
        SceneManager.LoadScene("Inicio");
    }

        public void ClosePressed()
    {
        Application.Quit();
    }
}
