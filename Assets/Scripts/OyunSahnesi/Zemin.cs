using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zemin : MonoBehaviour
{
    public float ZýplamaKuvveti;


    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.relativeVelocity.y < 0) 
        {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                Vector2 ZýplamaVelocity = rb.velocity;
                ZýplamaVelocity.y = ZýplamaKuvveti;
                rb.velocity = ZýplamaVelocity;
            }
        }

       
    }






}
