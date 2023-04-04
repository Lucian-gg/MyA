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
        EventManager.instance.Suscribe("OnProgress", OnProgress);
    }

    private void OnProgress(params object[] parameters)
    {
        print(parameters[0]);

        ScoreNumber += 1;
        score.text = "" + ScoreNumber;
    }
}
