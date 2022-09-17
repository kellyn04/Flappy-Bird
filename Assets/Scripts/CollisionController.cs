using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollisionController : MonoBehaviour
{

   // public static int puntaje = 0;

    //void Start()
   // {
      //  puntaje = 0;
    //}

    private void OnTriggerEnter2D(Collider2D collision)
    {

        punctuationController.puntaje++;
            //sceneController.Gameover();
            //sceneController.GetComponent<SceneController>().Gameover();
          //  puntaje = puntaje++;
        
        
    }
}
