using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerModel model;
    private Rigidbody2D rb;
    private List<IWeapon> Weapons = new List<IWeapon>();
    private IWeapon CurrentWeapon;

    public float Modifier;

    private void Start()
    {
        Modifier = 1;
        model = GetComponent<PlayerModel>();
        rb = GetComponent<Rigidbody2D>();

        IWeapon AutomaticWeapon = GetComponent<AutomaticWeapon>();
        Weapons.Add(AutomaticWeapon);

        CurrentWeapon = Weapons[0];

        EventManager.instance.Suscribe("OnSpeedBuff", Speedboost);
        EventManager.instance.Suscribe("OnDebuffDir", InvertDir);

        //StartCoroutine(GrowSpeed());
    }

    public IEnumerator GrowSpeed()
    {
        yield return new WaitForSeconds(5f);
        model._speedY += 1f;
        StartCoroutine(GrowSpeed());
    }

    private void Speedboost(object[] parameters)
    {
        model._speedY += (float)parameters[0];
    }

    private void InvertDir(object[] parameters)
    {
        Modifier *= (int)parameters[0];
    }

    private void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horizontalInput*Modifier * model._speedX, model._speedY); //Set velocity every fixedFrame
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CurrentWeapon.Shoot();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Buff")
        {
            IPowerUp buff1 = collision.gameObject.GetComponent<IPowerUp>();
            //IPowerUp buff1 = FindObjectOfType<MediKit>();
            buff1.Buff();
            print("wtf");
        }
    }
}
