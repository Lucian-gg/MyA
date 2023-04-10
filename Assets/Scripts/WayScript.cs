using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayScript : MonoBehaviour
{
    public GameObject Road;
    public Transform LocationSpawn;
    public List<GameObject> EnemyList= new List<GameObject>();
    private const string playerString = "Player";

    private void Start()
    {
        Instantiate(EnemyList[Random.Range(0, EnemyList.Count)], LocationSpawn.position, Quaternion.identity);

    }



    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.CompareTag(playerString)) Instantiate(Road, LocationSpawn.position, Quaternion.identity);

    }

}
