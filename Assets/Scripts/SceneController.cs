using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

    public GameObject canvasGameover;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

   
  
    /*
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Pared")
        {
            canvasGameover.SetActive(true);
            Time.timeScale = 0;
        }

    }
    */

    public void Gameover()
    {
    canvasGameover.SetActive(true);
    Time.timeScale = 0;

    }


    public void Reiniciar()
    {
        SceneManager.LoadScene(0);
    }

}
