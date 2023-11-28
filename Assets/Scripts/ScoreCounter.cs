using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ScoreCounter : MonoBehaviour
{
    public int golpes;
    public int moneda;

    public GameObject camaraGO;

    public TextMeshProUGUI textoMonedas;
    public TextMeshProUGUI textoGolpes;

    void OnCollisionEnter (Collision other)
    {
        if(!other.gameObject.CompareTag("Suelo") && !other.gameObject.CompareTag("Finishh"))
        {
        golpes++;
        UpdateScoreG();
        }
    }

    void OnTriggerEnter (Collider others)
    {
        if(others.gameObject.CompareTag("Moneda"))
        {
            moneda++;
            Destroy(others.gameObject);
            UpdateScoreM();
        }
        else
        {
            if(others.gameObject.CompareTag("Finishh"))
                camaraGO.SetActive(true);
            else
            {
                golpes++;
                UpdateScoreG();
            }
            
        }
    }

    public void UpdateScoreG()
    {
        textoGolpes.text = golpes.ToString();  
    }

    public void UpdateScoreM()
    {
        textoMonedas.text = moneda.ToString();
    }
}