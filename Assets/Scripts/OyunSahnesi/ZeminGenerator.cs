using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeminGenerator : MonoBehaviour
{
    public GameObject zemin;

    private Transform tr;

    public int zeminsayısı;
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

        }



    }


}
