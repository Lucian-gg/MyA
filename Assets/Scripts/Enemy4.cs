using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy4 : Enemy1
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            EventManager.instance.Trigger("OnEnemyDestroyed");
            print("Im invincible! but still give points.");
        }
    }
}
