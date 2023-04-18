using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMini3 : Enemy1
{
    private void Start()
    {
        
    }

    private void FixedUpdate()
    {
        transform.localPosition += transform.up*0.1f;
    }

}
