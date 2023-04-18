using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMini3 : MonoBehaviour
{
    private void FixedUpdate()
    {
        transform.localPosition += transform.up*0.1f;
    }
}
