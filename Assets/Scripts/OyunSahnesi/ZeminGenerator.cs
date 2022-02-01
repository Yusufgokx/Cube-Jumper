using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeminGenerator : MonoBehaviour
{
   
    public GameObject zemin;

    private Transform tr;
    public GameObject coin;
    public GameObject redcoin;

    public int zeminsayısı;
    public int minCoin;
    public int maxCoin;
    public float zemingenislik;
    public float minimumy, maximumy;
  
    


    private void Start()
    {
        tr = zemin.GetComponent<Transform>();
        Vector3 spawnkonumu = new Vector3();
        Vector2 yeniscale = new Vector2();

        for(int i=0; i<zeminsayısı; i++)
        {
            yeniscale.x = Random.Range(0.9f, 1.1f);
            yeniscale.y = Random.Range(0.9f, 1.1f);
            tr.localScale = yeniscale;

            spawnkonumu.y += Random.Range(minimumy,maximumy);
            spawnkonumu.x = Random.Range(-zemingenislik, zemingenislik);

            Instantiate(zemin, spawnkonumu, Quaternion.identity);
            
            var RastgeleCoinoluşturma = Random.Range(minCoin, maxCoin);

            if (RastgeleCoinoluşturma == 1)
            {
                Instantiate(coin, spawnkonumu + Vector3.up, Quaternion.identity);
            }
            else if (RastgeleCoinoluşturma == 2) 
            {
                Instantiate(redcoin , spawnkonumu + Vector3.up, Quaternion.identity);
            }
            
           
              
        }



    }


}
