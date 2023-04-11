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
        EventManager.instance.Suscribe("OnProgress", OnProgress2);
    }

    private void FixedUpdate()
    {
        ScoreNumber += 1;
        score.text = "" + ScoreNumber;
    }
    private void OnProgress2(params object[] parameters)
    {
        //print("EventManager: "  + this.GetType().Name);
    }
}




// _instance.Trigger("OnProgress"); ej.
