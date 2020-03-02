using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {


    public float Speed = 0f;
    public Vector3 Vectordirector;
    public GameObject m_Ship;
    private GameManager m_GameManager;
    public GameObject ResetBall;
    public AudioSource soundfx;
    public AudioClip wall;

    // Use this for initialization
    void Start () {
        m_GameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();


        int random = Random.Range(0, 2);

        if (random == 0)
            Vectordirector = Vector3.up + Vector3.right;

        else if (random == 1)
            Vectordirector = Vector3.up + Vector3.left;
	}
	
	// Update is called once per frame
	void Update () {


        IntersectBounds(GetComponent<SpriteRenderer>(), m_Ship.GetComponent<SpriteRenderer>());


        // Speed
        this.transform.position += Time.deltaTime * Speed * Vectordirector;

        // BOUNCES 
     
        // GoLeftUp
        if (transform.position.x > 1f && Vectordirector.y > 0)
        {
            Vectordirector = Vector3.left + Vector3.up;
            soundfx.clip = wall;
            soundfx.Play();

        }
        //GoRightUp
        else if (transform.position.x < -8.5f && Vectordirector.y > 0)
        {
            Vectordirector = Vector3.right + Vector3.up;
            soundfx.clip = wall;
            soundfx.Play();
        }
        //GoRightDown
        else if (transform.position.x < -8.5f && Vectordirector.y < 0)
        {
            Vectordirector = Vector3.right + Vector3.down;

        }
        //GoLeftDown
        else if (transform.position.x > 1f && Vectordirector.y < 0)
        {
            Vectordirector = Vector3.left + Vector3.down;
            soundfx.clip = wall;
            soundfx.Play();
        }
        //Up

        else if (transform.position.y > 4.635f && Vectordirector.x > 0)
        {
            Vectordirector = Vector3.right + Vector3.down;
            soundfx.clip = wall;
            soundfx.Play();
        }

        else if (transform.position.y > 4.635f && Vectordirector.x < 0)
        {
            Vectordirector = Vector3.left + Vector3.down;
            soundfx.clip = wall;
            soundfx.Play();
        }

        if (transform.position.y < -6f) {
            this.transform.position = ResetBall.transform.position;
            m_GameManager.m_vidas -= 1;
            Speed = 0f;
            this.transform.SetParent(m_Ship.transform);
        }

        //SHIP BOUNCE

        if (IntersectBounds(GetComponent<SpriteRenderer>(), m_Ship.GetComponent<SpriteRenderer>()) == true) {
            if (Vectordirector.x > 0)
            {
                Vectordirector = Vector3.up + Vector3.right;

            }
            else if (Vectordirector.x < 0) {
                Vectordirector = Vector3.up + Vector3.left;
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
