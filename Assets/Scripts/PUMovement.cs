using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUMovement : MonoBehaviour {

    public Vector3 Vectordirector;
    private float Speed = 1f;
    

    // Use this for initialization
    void Start () {

        Vectordirector = Vector3.down;

    }
	
	// Update is called once per frame
	void Update () {

        this.transform.position += Time.deltaTime * Speed * Vectordirector;

        if (transform.position.y < -6f)
        {
            Destroy(this.gameObject);
        }

        

    }

    

}
