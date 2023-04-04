using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayScript : MonoBehaviour
{
    public GameObject Road;
    public Transform LocationSpawn;

    private const string playerString = "Player";

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.CompareTag(playerString)) Instantiate(Road, LocationSpawn.position, Quaternion.identity);

    }

}
