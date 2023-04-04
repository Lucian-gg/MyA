using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicGun : MonoBehaviour, IWeapon
{
    public GameObject Bullet;
    public void Shoot()
    {
        Instantiate(Bullet, transform.position, Quaternion.identity);
    }




    /*
     private Pool<Bullet> _bulletPool;
    public Transform bulletSpawnPos;

    public GameObject nave; 

    void Awake()
    {
        var factory = new BulletFactory();
        _bulletPool = new Pool<Bullet>(factory.Create, Bullet.TurnOn, Bullet.TurnOff, 5);

    }


    public void Shoot()
    {
        
        var bullet = _bulletPool.Get();
        bullet.pool = _bulletPool;
        bullet.transform.position = bulletSpawnPos.position;
        bullet.transform.forward =  nave.transform.forward;
        bullet.transform.rotation = nave.transform.rotation;
    }

     
     */
}
