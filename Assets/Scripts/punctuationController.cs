using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class punctuationController : MonoBehaviour
{
    //public int Puntaje;
    public static int puntaje = 0;
    // Start is called before the first frame update
    void Start()
    {
        puntaje = 0;
    }

    // Update is called once per frame
    void Update()
    {

        //GetComponent<TextMeshProUGUI>().text = puntaje.ToString();
        GetComponent<UnityEngine.UI.Text>().text = puntaje.ToString();
        //GameObject puntajeNew = Instantiate(puntaje);
        //puntajeNew.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);

    }

    

}


