using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerSkorSahne : MonoBehaviour
{

    private void Update()
    {
        LoadScene();//Fonksyonla yani aşağıdaki load scane fonksyonunu updatede çağırdık daha temiz bir kodlama biçimidir 
        
    }
    public void LoadScene()
    {
        if (Input.GetMouseButton(0))
        {
            SceneManager.LoadScene(0);
        }
    }
}
