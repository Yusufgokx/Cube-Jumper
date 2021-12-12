using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarakterHareket : MonoBehaviour
{
    public float harakethizi;
    private float yatayhareket;
    Rigidbody2D rb;

        private void Start(){
        rb = GetComponent<Rigidbody2D>();
        }



        private void Update(){
        yatayhareket = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(yatayhareket * harakethizi*Time.deltaTime,rb.velocity.y);
        }




}
