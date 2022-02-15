using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MissileFire : MonoBehaviour
{
    // missile got the physics component, speed and the firshot condition
    public Rigidbody2D rb;
    public float speed = 100f;
    public bool fireshot;

    // Start is called before the first frame update
    void Start()
    {
        fireshot = false;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // getting the user input and checking the fireshot condition
        if(Input.GetKeyDown(KeyCode.Space) && fireshot == false )
        {
            missileFire();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //checking tag that gameobject has, after collision with UFO
        if (collision.gameObject.tag == "Missilestuck")
        {
          //checking the gameover condition that the 
            //gameover or not after colliding with missile
            //that stcuk with Ufo
            GameManager.isGameOver = true;
            gameObject.SetActive(false);
        }
    }

    // function is made if fireshot is true
    // then missile is going up with define speed and 
    //Add an instant force impulse to the rigidbody2D, using its mass.
    void missileFire()
    {
        fireshot = true;
        rb.AddForce(Vector2.up * speed, ForceMode2D.Impulse);
        
    }
}
