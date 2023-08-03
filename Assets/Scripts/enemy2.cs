using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy2 : Enemy1
{
    public GameObject wall;
    [SerializeField]
    private Vector3 offset = new Vector3(4.5f,0,0);
    public float dir;
    private void Start()
    {
        Instantiate(wall, transform.position + offset, Quaternion.identity);
        Instantiate(wall, transform.position - offset, Quaternion.identity);
        Destroy(gameObject, 13f);
    }

    private void FixedUpdate()
    {
        transform.position += new Vector3( dir, 0, 0);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Boing")
        {
            dir *= -1;
        }

        if (collision.gameObject.tag == "Bullet")
        {
            EventManager.instance.Trigger("OnEnemyDestroyed", 750);
            Destroy(gameObject);
        }
    }


}
