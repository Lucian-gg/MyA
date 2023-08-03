using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediKit : MonoBehaviour, IPowerUp
{
    private IPowerUp _next;
    public void Buff()
    {
        EventManager.instance.Trigger("OnKitBuff", 5000);
        Destroy(gameObject);
    }

}

