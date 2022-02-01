using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //***
using UnityEngine.SceneManagement;
public class Score : MonoBehaviour
{
    public Text skor;
    public static float SkorSayisi;
    public bool oyunekranim = true;
    public Text scores, highscores;
    public GameObject HighScoreObje;
    public bool YuksekSkorDegısme;

    private void Start()
    {
        #region control 
        // region yazıldıgından ıtıbaren endregıona kadar olan kısmı bır kutuphaneye cevırır ama null bır degerdır bostur duzen acısındandır.
        #endregion
        
        if (oyunekranim == false)
        {
            HighScoreObje.SetActive(false);

        }
       
    }
    private void Awake()
    {
        if (!PlayerPrefs.HasKey("High-Score"))
        {
            PlayerPrefs.SetFloat("High-Score", 0);
        }

    }

    void Update()
    {
        if (oyunekranim == false)
        {
            scores.text = PlayerPrefs.GetFloat("Score").ToString();
            highscores.text = PlayerPrefs.GetFloat("High-Score").ToString();
        }
        Skoreyazdir();
     
    }
    public void Skoreyazdir()
    {
        if (oyunekranim == true)
        {
            skor.text = SkorSayisi.ToString();

        }

    }

    public  void oldur()
    {
        PlayerPrefs.SetFloat("Score", SkorSayisi);
        if (PlayerPrefs.GetFloat("High-Score")<SkorSayisi)
        {
            PlayerPrefs.SetFloat("High-Score", SkorSayisi);
            //HighScoreObje.SetActive(true);
           
        }
        SceneManager.LoadScene("SkorSahnesi");
        SkorSayisi = 0;
        
       

    }
    
}
