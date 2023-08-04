using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menulevelscript : MonoBehaviour
{



    void Start()
    {
        EventManager.instance.Suscribe("OnMenuLevelOn", TurnOn);

    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.F)) {
            print("AAAHHHH");
            TurnOn2();
        
        }
    }

    private void TurnOn(object[] parameters)
    {
        gameObject.SetActive(true);
    }

    public void TurnOn2()
    {
        print("AAAHHHH");
        gameObject.SetActive(true);
    }
}
