using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ballmovement : MonoBehaviour
{
    public float xSpeed = 0; //variable for x movement
    public float ySpeed = 0; //variable for y movement

    private float xBorder = 8f; //varible for x dimension border of the game
    private float yBorder = 4.5f; //varible for y dimension border of the game

    //variable for move state
    public bool xMove = true;
    public bool yMove = true;

    //variables for score
    int playerOneScore;
    public Text scoreTextP1;

    int playerTwoScore;
    public Text scoreTextP2;

    // Start is called before the first frame update
    void Start()
    {
        xSpeed = 0.02f;
        ySpeed = 0.01f;
    }

    // Update is called once per frame
    void Update()
    {
        if (xMove == true)
        {
            transform.position = new Vector2(transform.position.x + xSpeed, transform.position.y); //move right
        }
        else
        {
            transform.position = new Vector2(transform.position.x - xSpeed, transform.position.y); //move left
        }

        if (yMove == true)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + ySpeed); //move right
        }
        else
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - ySpeed); //move left
        }

        if (transform.position.x >= xBorder)
        {
            xMove = false;
            transform.position = new Vector2(0, 0);
            xSpeed = 0.01f;
            ySpeed = 0.01f;
            playerOneScore += 1;
            
        }
        if (transform.position.y >= yBorder)
        {
            yMove = false;
            xSpeed += 0.001f;
            ySpeed += 0.001f;
        }
        if (transform.position.x <= -xBorder)
        {
            xMove = true;
            transform.position = new Vector2(0, 0);
            xSpeed = 0.01f;
            ySpeed = 0.01f;
            playerTwoScore += 1;
        }
        if (transform.position.y <= -yBorder)
        {
            yMove = true;
            xSpeed += 0.001f;
            ySpeed += 0.001f;
        }

        scoreTextP1.text = playerOneScore.ToString();

        scoreTextP2.text = playerTwoScore.ToString();
    }
    void OnCollisionEnter2D(Collision2D collision) //when a collision happens
    {
        Debug.Log("Hit");
        if (collision.collider.CompareTag("Player"))
        {
            if (xMove == true)
            {
                xMove = false;
                xSpeed += 0.001f;
                ySpeed += 0.001f;
            }
            else if (xMove == false)
            {
                xMove = true;
                xSpeed += 0.001f;
                ySpeed += 0.001f;
            }
        }
    }
}
