using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private PlayerModel model;
    private Rigidbody2D rb;

    private void Start()
    {
        model = GetComponent<PlayerModel>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {

        float horizontalInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(horizontalInput * model._speedX, model._speedY); //Set velocity every fixedFrame

    }

    
















}
