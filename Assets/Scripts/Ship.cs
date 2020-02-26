using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour {

    // Velocitat
    public float speed = 0.5f;
    private Vector3 playerPosition;
    public float border;
    public GameObject m_Ship;

    public GameObject m_ball;

    //public Sprite Powerupcontrols;
    //public Sprite Enlarge;
    //public Sprite Iron;
    //public Sprite Multiply;
    //public Sprite Sticky;
    //public Sprite Velocity;

    // Use this for initialization
    void Start () {

        playerPosition = gameObject.transform.position;

        // GetComponent<SpriteRenderer>().sprite= 


    }
	
	// Update is called once per frame
	void Update () {



        // Moviment 
       

        if (Input.GetAxis("Horizontal") < 0 && playerPosition.x > -7.75f) {
            playerPosition.x += Input.GetAxis("Horizontal") * speed;
        }

        if (Input.GetAxis("Horizontal") > 0 && playerPosition.x < 0.3f)
        {
            playerPosition.x += Input.GetAxis("Horizontal") * speed;
        }


        // Ball
        if (Input.GetKeyDown(KeyCode.Space))
        {
            m_ball.GetComponent<Ball>().Speed = 5f;
            m_ball.transform.SetParent(null);

        }

        transform.position = playerPosition;

    }



}
