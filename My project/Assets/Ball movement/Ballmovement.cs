using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballmovement : MonoBehaviour
{
    public float xSpeed = 0; //variable for x movement
    public float ySpeed = 0; //variable for y movement

    private float xRightBorder = 9.5f; //varible for x dimension border of the game
    private float yUpBorder = 7.5f; //varible for y dimension border of the game
    private float xLeftBorder = -9.5f; //varible for x dimension border of the game
    private float yDownBorder = -7.5f; //varible for y dimension border of the game

    //variable for move state
    public bool xMove = true;
    public bool yMove = true;

    // Start is called before the first frame update
    void Start()
    {
        xSpeed = 0.01f;
        ySpeed = 0.01f;
    }

    // Update is called once per frame
    void Update()
    {
        if (xMove == true)
        {
            transform.position = new Vector2(transform.position.x + xSpeed, transform.position.y + ySpeed); //move right
        }
        else
        {
            transform.position = new Vector2(transform.position.x - xSpeed, transform.position.y - ySpeed); //move left
        }
        
        if (transform.position.x >= xRightBorder)
        {
            xMove = false;
        }
        if (transform.position.y >= yUpBorder)
        {
            yMove = false;
        }
        if (transform.position.x <= xLeftBorder)
        {
            xMove = true;
        }
        if (transform.position.y <= yDownBorder)
        {
            yMove = true;
        }
    }
    void OnCollisionEnter2D(Collision2D collision) //when a collision happens
    {
        Debug.Log("Hit");
        if (collision.collider.CompareTag("Player"))
        {
            if (xMove == true)
            {
                xMove = false;
            }
            else if (xMove == false)
            {
                xMove = true;
            }
        }
    }
}
