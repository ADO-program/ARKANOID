using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour {

    // Velocitat
    public float speed = 0.5f;
    private Vector3 playerPosition;
    public float border;
    public GameObject m_Ship;


    // Use this for initialization
    void Start () {

        playerPosition = gameObject.transform.position;
    }
	
	// Update is called once per frame
	void Update () {

        IntersectBounds(GetComponent<SpriteRenderer>(), m_Ship.GetComponent<SpriteRenderer>());

        // Moviment 
        playerPosition.x += Input.GetAxis("Horizontal") * speed;

        // Menu
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
        }

        
        transform.position = playerPosition;

    }
    public bool IntersectBounds(SpriteRenderer l_border, SpriteRenderer l_Ship)
    {
        return l_border.bounds.max.x > l_Ship.bounds.min.x && l_border.bounds.min.x > l_Ship.bounds.max.x;
    }
}
