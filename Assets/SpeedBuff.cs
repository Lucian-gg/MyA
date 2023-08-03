using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBuff : MonoBehaviour, IPowerUp
{
    public void Buff()
    {
        EventManager.instance.Trigger("OnSpeedBuff", -2f);
        Destroy(gameObject);
    }
}
