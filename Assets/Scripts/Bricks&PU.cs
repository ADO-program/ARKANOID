using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bricks : MonoBehaviour {

    public GameObject m_ball1;



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        IntersectBounds(GetComponent<SpriteRenderer>(), m_ball1.GetComponent<SpriteRenderer>());

        // BOUNCES 

        if (IntersectBounds(GetComponent<SpriteRenderer>(), m_ball1.GetComponent<SpriteRenderer>()) == true)
        {

            //coming from left
            if(m_ball1.transform.position.x < this.GetComponent<SpriteRenderer>().bounds.min.x)
            {
                //subiendo?
                if (m_ball1.GetComponent<Ball>().Vectordirector.y > 0)
                {
                    m_ball1.GetComponent<Ball>().Vectordirector = Vector3.left + Vector3.up;
                }
                //bajando
                else if(m_ball1.GetComponent<Ball>().Vectordirector.y < 0)
                {
                    m_ball1.GetComponent<Ball>().Vectordirector = Vector3.left + Vector3.down;
                }

            }

            //coming from right
            if (m_ball1.transform.position.x > this.GetComponent<SpriteRenderer>().bounds.max.x)
            {
                //subiendo
                if (m_ball1.GetComponent<Ball>().Vectordirector.y > 0)
                {
                    m_ball1.GetComponent<Ball>().Vectordirector = Vector3.right + Vector3.up;
                }
                //bajando
                else if(m_ball1.GetComponent<Ball>().Vectordirector.y < 0)
                {
                    m_ball1.GetComponent<Ball>().Vectordirector = Vector3.right + Vector3.down;
                }

            }

            //coming from above
            if (m_ball1.transform.position.y > this.GetComponent<SpriteRenderer>().bounds.max.y)
            {
                //derecha
                if (m_ball1.GetComponent<Ball>().Vectordirector.x > 0)
                {
                    m_ball1.GetComponent<Ball>().Vectordirector = Vector3.right + Vector3.up;
                }
                //izquierda
                else if(m_ball1.GetComponent<Ball>().Vectordirector.x < 0)
                {
                    m_ball1.GetComponent<Ball>().Vectordirector = Vector3.left + Vector3.up;
                }

            }

            //coming from under
            if (m_ball1.transform.position.y < this.GetComponent<SpriteRenderer>().bounds.min.y)
            {
                //derecha
                if (m_ball1.GetComponent<Ball>().Vectordirector.x > 0)
                {
                    m_ball1.GetComponent<Ball>().Vectordirector = Vector3.right + Vector3.down;
                }
                //izquierda
                else if(m_ball1.GetComponent<Ball>().Vectordirector.x < 0)
                {
                    m_ball1.GetComponent<Ball>().Vectordirector = Vector3.left + Vector3.down;
                }

            }


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
