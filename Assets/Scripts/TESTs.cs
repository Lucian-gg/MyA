using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TESTs : MonoBehaviour
{
    delegate void MyDelegate(params object[] Params);
    private MyDelegate myDelegate;

    void Start()
    {
        myDelegate += Method1;
        myDelegate += Method2;

        Delegate[] delegates = myDelegate.GetInvocationList();

        foreach (var del in delegates)
        {
            Debug.Log("Subscribed method: " + del.Method.Name);
        }
    }

    void Method1(params object[] Params)
    {
        Debug.Log(Params[0]);
    }

    void Method2(params object[] Params)
    {
        Debug.Log(Params[1]);
    }
}
