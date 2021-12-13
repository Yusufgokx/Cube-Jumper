using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zemin : MonoBehaviour
{
    public float Z�plamaKuvveti;


    private void OnCollisionEnter2D(Collision2D collision){
       Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
        if (rb != null){
            Vector2 Z�plamaVelocity = rb.velocity;
            Z�plamaVelocity.y = Z�plamaKuvveti;
            rb.velocity = Z�plamaVelocity;
        }
    }






}
