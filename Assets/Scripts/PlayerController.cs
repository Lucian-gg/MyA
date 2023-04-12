using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerModel model;
    private Rigidbody2D rb;
    private List<IWeapon> Weapons = new List<IWeapon>();
    private IWeapon CurrentWeapon;

    private void Start()
    {
        model = GetComponent<PlayerModel>();
        rb = GetComponent<Rigidbody2D>();

        IWeapon AutomaticWeapon = GetComponent<AutomaticWeapon>();
        Weapons.Add(AutomaticWeapon);

        CurrentWeapon = Weapons[0];
    }

    private void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horizontalInput * model._speedX, model._speedY); //Set velocity every fixedFrame
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CurrentWeapon.Shoot();
        }
    }
}
