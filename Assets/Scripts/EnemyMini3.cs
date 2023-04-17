using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMini3 : MonoBehaviour
{
    private void FixedUpdate()
    {
        transform.position += Vector3.up*0.05f;
    }
}
