using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerModel model;
    private Rigidbody2D rb;
    private List<IWeapon> Weapons = new List<IWeapon>();
    private IWeapon CurrentWeapon;

    private EventManager _instance;

    private void Start()
    {

        
        model = GetComponent<PlayerModel>();
        rb = GetComponent<Rigidbody2D>();

        IWeapon AutomaticWeapon = GetComponent<AutomaticWeapon>();
        Weapons.Add(AutomaticWeapon);

        CurrentWeapon = Weapons[0];

        _instance = EventManager.instance;

      //  InvokeRepeating("UpdateScore", 0, 0.1f);
    }

    private void FixedUpdate()
    {

        float horizontalInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horizontalInput * model._speedX, model._speedY); //Set velocity every fixedFrame

        _instance.Trigger("OnProgress");



    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            CurrentWeapon.Shoot();
        }

    }


    public void UpdateScore()
    {
        _instance.Trigger("OnProgress", "funciona");
    }

    
}
