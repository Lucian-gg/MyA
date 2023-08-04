using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debuff1 : MonoBehaviour, IPowerUp
{
    public void Buff()
    {
        EventManager.instance.Trigger("OnKitBuff", -5000);
        EventManager.instance.Trigger("OnSpeedBuff", -2f);
        Destroy(gameObject);
    }
}
