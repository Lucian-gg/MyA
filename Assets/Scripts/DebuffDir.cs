using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebuffDir : MonoBehaviour, IPowerUp
{
    public void Buff()
    {
        EventManager.instance.Trigger("OnDebuffDir", -1);
        Destroy(gameObject);
    }
}
