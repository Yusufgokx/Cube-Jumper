using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarakterHareket : MonoBehaviour
{
    public float harekethizi;
    private float yatayhareket;

    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        yatayhareket = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(yatayhareket * harekethizi * Time.deltaTime,rb.velocity.y);
        Vector2 yeniscale = transform.localScale;

        if(yatayhareket>0)
        {
            yeniscale.x = 0.35f;
        }
        if (yatayhareket < 0)
        {
            yeniscale.x = -0.35f;
        }
        transform.localScale = yeniscale;

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            Score.SkorSayisi += 5;
            Destroy(collision.gameObject);
        }

    }


}
