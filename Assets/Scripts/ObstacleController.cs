using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{

    public float timeMax = 1;
    private float initialTime = 0;
    public GameObject paredes;
    public float height;

    // Start is called before the first frame update
    void Start()
    {
        GameObject obstacleNew = Instantiate(paredes);
        obstacleNew.transform.position = transform.position + new Vector3(0, 0, 0);
        Destroy(obstacleNew, 10);
    }

    // Update is called once per frame
    void Update()
    {
        if(initialTime > timeMax)
        {
           GameObject obstacleNew = Instantiate(paredes);
           obstacleNew.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
           Destroy(obstacleNew, 10);
           initialTime = 0;

        }

        else
        {
            initialTime += Time.deltaTime;
        }
    }
}
