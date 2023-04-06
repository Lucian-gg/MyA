using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public class AutomaticWeapon : MonoBehaviour, IWeapon
{
    
    private Pool<Bullet> BulletPool;
    public Transform BulletSpawnPos;

    public GameObject Nave;

    public List<Bullet> pool = new List<Bullet>();

    void Awake()
    {
        var factory = new BulletFactory();
        BulletPool = new Pool<Bullet>(factory.Create, Bullet.TurnOn, Bullet.TurnOff, 5);

    }

    void Start()
    {
        pool = BulletPool.GetFullPool();
    }


    public void Shoot()
    {
        
        var bullet = BulletPool.Get();
        bullet.BulletPool = BulletPool;
        bullet.transform.position = transform.position;
        bullet.transform.forward =  transform.forward;
        bullet.transform.rotation = transform.rotation;
    }

   

}
