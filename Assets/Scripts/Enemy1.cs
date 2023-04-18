using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    private void Start()
    {
        transform.position = new Vector3(transform.position.x + Random.Range(-5f, 5f), transform.position.y, transform.position.z);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            EventManager.instance.Trigger("OnEnemyDestroyed");
            Destroy(gameObject);
        }
    }













}
