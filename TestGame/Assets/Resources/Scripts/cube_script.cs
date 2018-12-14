using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube_script : MonoBehaviour {

    public GameObject cube00;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        moveCubeCircle();

    }

    void moveCubeCircle()
    {
        Vector3 move = new Vector3();
        if(cube00.transform.position.x < 5)
        {
            move.x = cube00.transform.position.x + 1;
        }
        else if(cube00.transform.position.y < 5)
        {
            move.y = cube00.transform.position.y + 1;
        }

        int lolo;

        cube00.transform.position = move;
    }
}
