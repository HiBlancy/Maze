using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PuntuacionFinal : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textoMonedass;
    [SerializeField] TextMeshProUGUI textoGolpess;

    void OnGUI()
    {
        textoMonedass.text = ScoreManager.obj.moneda.ToString();
        textoGolpess.text = ScoreManager.obj.golpes.ToString();
    }
}