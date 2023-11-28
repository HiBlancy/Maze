using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinalPuntos : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textoMonedass;
    [SerializeField] TextMeshProUGUI textoGolpess;

    public ScoreCounter puntuacionesFinales;
    
    void OnGUI ()
    {
        textoMonedass.text = puntuacionesFinales.moneda.ToString();
        textoGolpess.text = puntuacionesFinales.golpes.ToString();
    }
}