using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {





    // Use this for initialization

    public Text m_TextPuntuacio;
    public Text m_TextVidas;
    public GameObject m_GameRestart;

    public int m_bricks = 33;


    [HideInInspector] public float m_score;
    public int m_vidas;

    void Start () {
        if (SceneManager.GetActiveScene().buildIndex == 1)
        {
            m_bricks = 23;
        }
        else if (SceneManager.GetActiveScene().buildIndex == 2)
        {
            m_bricks = 35;
        }

    }

    // Update is called once per frame
    void Update() {

        m_TextPuntuacio.text = "Score: " + Mathf.Round(m_score);
        m_TextVidas.text = "" + m_vidas;

        Vidas();
        if (((m_bricks == 0)&&(SceneManager.GetActiveScene().buildIndex == 1))||((m_bricks == 0) && (SceneManager.GetActiveScene().buildIndex == 0))) { 
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
            
        }


        // Menu
        if (Input.GetKeyDown(KeyCode.Escape))
        { 
           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void Vidas()
    {
        if ((m_vidas <= 0) || ((SceneManager.GetActiveScene().buildIndex == 2)&&(m_bricks == 0)))
        {
            m_GameRestart.SetActive(true);
        }


    }


    public void RestartGame()
    {
        m_GameRestart.SetActive(false);
        SceneManager.LoadScene(0);

       

    }
}
