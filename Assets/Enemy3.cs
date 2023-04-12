using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3 : Enemy1
{
    public GameObject Mini;
    private void OnDestroy()
    {
        for (int i = 0; i < 2; i++)
        {
            GameObject cosa = Instantiate(Mini, transform.position, Quaternion.identity);

            float z = Random.Range(0, 360f);
            Quaternion q = cosa.transform.rotation;
            q.z = z;

            cosa.transform.rotation = q;
        }
    }
}
