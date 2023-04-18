using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3 : Enemy1
{
    public GameObject Mini;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            EventManager.instance.Trigger("OnEnemyDestroyed");

            for (int i = 0; i < 3; i++)
            {
                GameObject cosa = Instantiate(Mini, transform.position, Quaternion.Euler(0f, 0f, Random.Range(0f, 360f)));
            }
            Destroy(gameObject);
        }
    }
}
