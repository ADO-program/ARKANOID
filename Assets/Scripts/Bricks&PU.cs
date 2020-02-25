using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour {

    public Vector3 Vectordirector;
    public GameObject m_ball1;



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        // BOUNCES 

        // GoLeftUp
        if ((IntersectBounds(GetComponent<SpriteRenderer>(), m_Ship.GetComponent<SpriteRenderer>()) == true) && )
        {
            Vectordirector = Vector3.left + Vector3.up;

        }
        //GoRightUp
        else if ((IntersectBounds(GetComponent<SpriteRenderer>(), m_Ship.GetComponent<SpriteRenderer>()) == true) && )
        {
            Vectordirector = Vector3.right + Vector3.up;

        }
        //GoRightDown
        else if ((IntersectBounds(GetComponent<SpriteRenderer>(), m_Ship.GetComponent<SpriteRenderer>()) == true) && )
        {
            Vectordirector = Vector3.right + Vector3.down;

        }
        //GoLeftDown
        else if ((IntersectBounds(GetComponent<SpriteRenderer>(), m_Ship.GetComponent<SpriteRenderer>()) == true) && )
        {
            Vectordirector = Vector3.left + Vector3.down;

        }
        //Up

        else if ((IntersectBounds(GetComponent<SpriteRenderer>(), m_Ship.GetComponent<SpriteRenderer>()) == true) && )
        {
            Vectordirector = Vector3.right + Vector3.down;

        }

        else if ((IntersectBounds(GetComponent<SpriteRenderer>(), m_Ship.GetComponent<SpriteRenderer>()) == true) && )
        {
            Vectordirector = Vector3.left + Vector3.down;

        }

    }

    public bool IntersectBounds(SpriteRenderer l_Ball, SpriteRenderer l_Nave)
    {
        return l_Ball.bounds.max.y > l_Nave.bounds.min.y
            && l_Ball.bounds.min.y < l_Nave.bounds.max.y
            && l_Ball.bounds.max.x > l_Nave.bounds.min.x
            && l_Ball.bounds.min.x < l_Nave.bounds.max.x;


    }
}
