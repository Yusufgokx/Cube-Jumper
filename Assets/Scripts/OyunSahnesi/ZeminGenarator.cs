using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeminGenarator : MonoBehaviour
{
    public GameObject zemin;
    private Transform tr;


    public int zeminsayýsý;
    public float zemingenislik;
    public float minimumy, maximumy;


    private void Start()
    {
        tr = zemin.GetComponent<Transform>();
        Vector3 spawnkonumu = new Vector3();
        Vector2 yeniscale = new Vector2();

        for (int i = 0; i<zeminsayýsý; i++)
        {
            yeniscale.x = Random.Range(0.9f, 1.1f);
            yeniscale.y = Random.Range(0.9f, 1.1f);
            tr.localScale = yeniscale;
            spawnkonumu.y += Random.Range(minimumy, minimumy);
            spawnkonumu.x = Random.Range(-zemingenislik, zemingenislik);

            Instantiate(zemin, spawnkonumu, Quaternion.identity);
        }




    }



}
