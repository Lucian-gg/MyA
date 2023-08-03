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
        EventManager.instance.Suscribe("OnKitBuff", GainPoints);
    }

    private void FixedUpdate()
    {
        ScoreNumber += 1;
        score.text = "" + ScoreNumber;
    }
    public void GainPoints(params object[] parameters)
    {
        ScoreNumber += (int)parameters[0];
        score.text = "" + ScoreNumber;
    }
}


