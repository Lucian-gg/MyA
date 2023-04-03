using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayScript : MonoBehaviour
{
    public GameObject Road;
    public Transform LocationSpawn;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        Instantiate(Road, LocationSpawn.position, Quaternion.identity);
    }


}
