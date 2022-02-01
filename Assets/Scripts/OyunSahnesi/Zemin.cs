using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zemin : MonoBehaviour
{
    public float ZıplamaKuvveti;
    public bool ZemineTemasEdildi;
    float rastgeledeger;
    Animator anim;
    int ZıplatanZeminIhtimali;

    private void Start()
    {
        anim = GetComponent<Animator>();
        ZıplatanZeminIhtimali = Random.Range(1, 11);
        if (ZıplatanZeminIhtimali == 1)
        {
            anim.SetBool("JumperFloor", true);
            ZıplamaKuvveti = 20f;
        }
        else
        {
            ZıplamaKuvveti = 13f;
        }
        Debug.Log("ONUR NABER");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (collision.relativeVelocity.y < 0)
        {

            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();

            if (rb != null)
            {
                Vector2 ZıplamaVelocity = rb.velocity;
                ZıplamaVelocity.y = ZıplamaKuvveti;
                rb.velocity = ZıplamaVelocity;

                if (ZemineTemasEdildi == false)
                {
                    rastgeledeger = Random.Range(1, 1);
                    Score.SkorSayisi += rastgeledeger;
                    Score.SkorSayisi++;
                    ZemineTemasEdildi = true;
                }
                anim.SetBool("TemasEdildi", true);
                Destroy(gameObject, 1f);
            }

        }








    }




}
