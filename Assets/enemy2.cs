using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy2 : Enemy1
{
    public GameObject wall;
    [SerializeField]
    private Vector3 offset = new Vector3(4.5f,0,0);
    private void Start()
    {
        Instantiate(wall, transform.position + offset, Quaternion.identity);
        Instantiate(wall, transform.position - offset, Quaternion.identity);
        print("asdad");
    }



}
