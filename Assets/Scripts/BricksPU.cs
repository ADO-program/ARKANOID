﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BricksPU : MonoBehaviour {

    public GameObject m_ball1;
    private int randomPU;
    public GameObject[] PowerUps;

    private GameManager m_GameManager;
    public AudioSource soundfx;
    public AudioClip brick;

    // Use this for initialization
    void Start () {
        m_GameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();

    }

    // Update is called once per frame
    void Update()
    {

        IntersectBounds(GetComponent<SpriteRenderer>(), m_ball1.GetComponent<SpriteRenderer>());

        // BOUNCES AND DESTRUCTION

        if (IntersectBounds(GetComponent<SpriteRenderer>(), m_ball1.GetComponent<SpriteRenderer>()) == true)
        {

            //coming from left
            if (m_ball1.transform.position.x < this.GetComponent<SpriteRenderer>().bounds.min.x)
            {
                //subiendo?
                if (m_ball1.GetComponent<Ball>().Vectordirector.y > 0)
                {
                    m_ball1.GetComponent<Ball>().Vectordirector = Vector3.left + Vector3.up;
                    soundfx.clip = brick;
                    soundfx.Play();
                }
                //bajando
                else if (m_ball1.GetComponent<Ball>().Vectordirector.y < 0)
                {
                    m_ball1.GetComponent<Ball>().Vectordirector = Vector3.left + Vector3.down;
                    soundfx.clip = brick;
                    soundfx.Play();
                }

            }

            //coming from right
            if (m_ball1.transform.position.x > this.GetComponent<SpriteRenderer>().bounds.max.x)
            {
                //subiendo
                if (m_ball1.GetComponent<Ball>().Vectordirector.y > 0)
                {
                    m_ball1.GetComponent<Ball>().Vectordirector = Vector3.right + Vector3.up;
                    soundfx.clip = brick;
                    soundfx.Play();
                }
                //bajando
                else if (m_ball1.GetComponent<Ball>().Vectordirector.y < 0)
                {
                    m_ball1.GetComponent<Ball>().Vectordirector = Vector3.right + Vector3.down;
                    soundfx.clip = brick;
                    soundfx.Play();
                }

            }

            //coming from above
            if (m_ball1.transform.position.y > this.GetComponent<SpriteRenderer>().bounds.max.y)
            {
                //derecha
                if (m_ball1.GetComponent<Ball>().Vectordirector.x > 0)
                {
                    m_ball1.GetComponent<Ball>().Vectordirector = Vector3.right + Vector3.up;
                    soundfx.clip = brick;
                    soundfx.Play();
                }
                //izquierda
                else if (m_ball1.GetComponent<Ball>().Vectordirector.x < 0)
                {
                    m_ball1.GetComponent<Ball>().Vectordirector = Vector3.left + Vector3.up;
                    soundfx.clip = brick;
                    soundfx.Play();
                }

            }

            //coming from under
            if (m_ball1.transform.position.y < this.GetComponent<SpriteRenderer>().bounds.min.y)
            {
                //derecha
                if (m_ball1.GetComponent<Ball>().Vectordirector.x > 0)
                {
                    m_ball1.GetComponent<Ball>().Vectordirector = Vector3.right + Vector3.down;
                    soundfx.clip = brick;
                    soundfx.Play();
                }
                //izquierda
                else if (m_ball1.GetComponent<Ball>().Vectordirector.x < 0)
                {
                    m_ball1.GetComponent<Ball>().Vectordirector = Vector3.left + Vector3.down;
                    soundfx.clip = brick;
                    soundfx.Play();
                }

            }

            randomPU = Random.Range(1,11);
            
            //hacer random
            if (randomPU <= 2)
            {

                CrearPowerUp(PowerUps[Random.Range(0, PowerUps.Length)]);

            }

            m_GameManager.m_score1 += 10;

            Destroy(this.gameObject);
            m_GameManager.m_bricks = m_GameManager.m_bricks-1;
            
            

        }

    }

    public bool IntersectBounds(SpriteRenderer l_Ball, SpriteRenderer l_Nave)
    {
        return l_Ball.bounds.max.y > l_Nave.bounds.min.y
            && l_Ball.bounds.min.y < l_Nave.bounds.max.y
            && l_Ball.bounds.max.x > l_Nave.bounds.min.x
            && l_Ball.bounds.min.x < l_Nave.bounds.max.x;


    }

    public void CrearPowerUp(GameObject l_PowerUps)
    {
        Instantiate(l_PowerUps, this.transform.position, Quaternion.identity);

    }

}
