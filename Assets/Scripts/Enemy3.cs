using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3 : Enemy1
{
    public GameObject Mini;

    private void Start()
    {
        Destroy(gameObject, 13f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            for (int i = 0; i < 3; i++)
            {
                GameObject cosa = Instantiate(Mini, transform.position, Quaternion.Euler(0f, 0f, Random.Range(0f, 360f)));
            }

            EventManager.instance.Trigger("OnEnemyDestroyed");
            Destroy(gameObject);
        }
    }
}
