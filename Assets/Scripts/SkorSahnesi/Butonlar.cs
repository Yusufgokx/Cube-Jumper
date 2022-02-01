using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Butonlar : MonoBehaviour
{
  public void yukle(string level)
    {
        SceneManager.LoadScene(level);


    }



}
