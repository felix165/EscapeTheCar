using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Menggerakkan object dengan arah vertikal dengan menekan key r terlebih dahulu

public class controlVertikal_r : MonoBehaviour
{
    Rigidbody2D car;
    private bool keyPressed = false;

    public float speed = 5.0f;
    public Vector2 movement;
    // Start is called before the first frame update
    void Start()
    {
        car = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame

    void Update()
    {
        movement = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        if (Input.GetKeyDown("r"))
        {
            keyPressed = true;
        }
        if (Input.GetKeyUp("r"))
        {
            keyPressed = false;
        }
    }

    void FixedUpdate()
    {
        if (keyPressed)
        {
            moveObject(movement);
        }
    }

    void moveObject(Vector2 direction)
    {
        car.MovePosition((Vector2)transform.position + (direction * speed * Time.deltaTime));
    }
}

