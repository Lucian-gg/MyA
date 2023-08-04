using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayScript : MonoBehaviour
{
    public GameObject Road;
    public Transform LocationSpawn, LocationSpawn2;
    public List<GameObject> EnemyList= new List<GameObject>();
    public List<GameObject> BuffsList = new List<GameObject>();
    private const string playerString = "Player";


    private void Start()
    {
        
        Instantiate(EnemyList[Random.Range(0, EnemyList.Count)], LocationSpawn.position, Quaternion.identity);
        if(Random.Range(0, 4) >= 3) 
        {
            Instantiate(BuffsList[Random.Range(0, BuffsList.Count)], LocationSpawn2.position, Quaternion.identity);
        }

        Destroy(gameObject, 13f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag(playerString)) Instantiate(Road, LocationSpawn.position, Quaternion.identity);
    }
}
