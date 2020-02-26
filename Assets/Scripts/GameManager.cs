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


    [HideInInspector] public float m_score;
    public int m_vidas;

    void Start () {


    }
	
	// Update is called once per frame
	void Update () {

        m_TextPuntuacio.text = "Score: " + Mathf.Round(m_score);
        m_TextVidas.text = "Vidas" + m_vidas;
        m_score += (Time.deltaTime);
        Vidas();


        // Menu
        if (Input.GetKeyDown(KeyCode.Escape))
        { 
           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void Vidas()
    {
        if (m_vidas <= 0)
        {
            m_GameRestart.SetActive(true);
        }


    }

    public void RestartGame()
    {
        m_GameRestart.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
