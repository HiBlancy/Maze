using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager obj { get; private set; }

    [SerializeField] TextMeshProUGUI textoMonedas;
    [SerializeField] TextMeshProUGUI textoGolpes;

    public int golpes;
    public int moneda;

    void Awake()
    {
        if (obj != null && obj != this)
            Destroy(this);
        else
            obj = this;
    }
    public void UpdateScoreG()
    {
        golpes++;
        textoGolpes.text = golpes.ToString();
    }

    public void UpdateScoreM()
    {
        moneda++;
        textoMonedas.text = moneda.ToString();
    }
}