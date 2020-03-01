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

    public GameObject m_ControlsPU;
    public bool m_ControlsPUc = true;

    public GameObject m_EnlargePU;
    public GameObject m_IronPU;
    public GameObject m_MultiplyPU;
    public GameObject m_StickyPU;
    public GameObject m_VelocityPU;

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

        if (IntersectBounds(GetComponent<SpriteRenderer>(), m_ControlsPU.GetComponent<SpriteRenderer>()) == true)
        {
        

        }
        else if (IntersectBounds(GetComponent<SpriteRenderer>(), m_EnlargePU.GetComponent<SpriteRenderer>()) == true)
        {


        }
        else if (IntersectBounds(GetComponent<SpriteRenderer>(), m_IronPU.GetComponent<SpriteRenderer>()) == true)
        {


        }
        else if (IntersectBounds(GetComponent<SpriteRenderer>(), m_MultiplyPU.GetComponent<SpriteRenderer>()) == true)
        {


        }
        else if (IntersectBounds(GetComponent<SpriteRenderer>(), m_StickyPU.GetComponent<SpriteRenderer>()) == true)
        {


        }
        else if(IntersectBounds(GetComponent<SpriteRenderer>(), m_VelocityPU.GetComponent<SpriteRenderer>()) == true)
        {


        }

    }

    
public bool IntersectBounds(SpriteRenderer l_PU, SpriteRenderer l_Nave)
{
    return l_PU.bounds.max.y > l_Nave.bounds.min.y
        && l_PU.bounds.min.y < l_Nave.bounds.max.y
        && l_PU.bounds.max.x > l_Nave.bounds.min.x
        && l_PU.bounds.min.x < l_Nave.bounds.max.x;

}



}
