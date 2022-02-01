using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadJump : MonoBehaviour
{
    public float ziplamaKuvveti;
    public GameObject myDiedFloor;
    void Start()
    {
        

    }


    void Update()
    {
        myDiedFloor.transform.position = new Vector2(0, myDiedFloor.transform.position.y+0.5f*Time.deltaTime);

    }
 

}
