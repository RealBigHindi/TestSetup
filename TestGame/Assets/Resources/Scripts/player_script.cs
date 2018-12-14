using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_script : MonoBehaviour {

    float player_speed;
    float rotationSpeed;

    // Use this for initialization
    void Start () {
        player_speed = 0.1f;
        rotationSpeed = 1.0f;
}
	
	// Update is called once per frame
	void Update () {
        
        set_movement(check_input());
        set_rotation(check_mouse_movement());
    }

    Vector2 check_input()
    {
        Vector2 movement = new Vector2(0, 0);    

        if (Input.GetKey("w"))
        {
            movement.x += 1;            
        }
        if(Input.GetKey("s"))
        {
            movement.x -= 1;
        }
        if (Input.GetKey("a"))
        {
            movement.y -= 1;
        }
        if (Input.GetKey("d"))
        {
            movement.y += 1;
        }

        return movement;
    }

    void set_movement(Vector2 move)
    {
        Vector3 move3 = new Vector3(move.y, 0, move.x);
        move3 *= player_speed;
        this.transform.Translate(move3);
    }
   
    Vector3 check_mouse_movement()
    {
        return new Vector3(Input.GetAxis("Mouse Y") * rotationSpeed, Input.GetAxis("Mouse X") * rotationSpeed, 0);
    }

    void set_rotation(Vector3 rotate)
    {
        this.transform.Rotate(rotate);
    }
}
