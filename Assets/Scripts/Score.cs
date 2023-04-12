using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI score;
    public int ScoreNumber;
    void Start()
    {
        EventManager.instance.Suscribe("OnEnemyDestroyed", GainPoints);
    }

    private void FixedUpdate()
    {
        ScoreNumber += 1;
        score.text = "" + ScoreNumber;
    }
    private void GainPoints(params object[] parameters)
    {
        ScoreNumber += 1000;
        score.text = "" + ScoreNumber;
    }
}


