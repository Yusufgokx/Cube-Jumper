using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //***
public class Score : MonoBehaviour
{
    public Text skor;
    public static float SkorSayisi;

  

   
    void Update()
    {
        skor.text = SkorSayisi.ToString();
    }
}
