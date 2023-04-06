using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class BulletFactory : IFactory<Bullet>
{

    public Bullet Create()
    {

        var bulletBuilder = new BulletBuilder(); 
        bulletBuilder.SetSpeed(20f);                                    
        var bullet = bulletBuilder.Craft();
        

        return bullet;
        

    }
    
}