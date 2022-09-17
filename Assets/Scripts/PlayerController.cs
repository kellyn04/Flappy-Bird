
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //public Director directorjuego;
    [SerializeField]
    private float jumpForce;

    [SerializeField]
    private float gravity;
    private Vector3 direction;

    public SceneController sceneController;

   
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            direction = Vector3.up * jumpForce;
        }

        direction.y += gravity * Time.deltaTime;
        transform.position += direction * Time.deltaTime;
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {

       
        if(collision.tag == "Pared")
        {
            //sceneController.Gameover();
            sceneController.GetComponent<SceneController>().Gameover();
        }
    }
    

    /*
    private void OnCollisionEnter2D(Collision2D collision)
    {
        sceneController.Gameover();
    }
    */
}
