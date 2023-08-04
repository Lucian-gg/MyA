using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI score;
    public int ScoreNumber;
    public int Puntos;
    void Start()
    {
        EventManager.instance.Suscribe("OnEnemyDestroyed", GainPoints);
        EventManager.instance.Suscribe("OnKitBuff", GainPoints);
        EventManager.instance.Suscribe("OnDefeat", StopPoints);
    }

    private void FixedUpdate()
    {
        ScoreNumber += Puntos;
        score.text = "" + ScoreNumber;
    }
    public void GainPoints(params object[] parameters)
    {
        ScoreNumber += (int)parameters[0];
        score.text = "" + ScoreNumber;
    }

    public void StopPoints(params object[] parameters)
    {
        Puntos = 0;
    }
}


