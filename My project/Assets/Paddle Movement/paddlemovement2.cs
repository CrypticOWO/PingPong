using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddlemovement2: MonoBehaviour
{
    public float ySpeed = 0.1f;
    public float yBorder = 3.5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W) && transform.position.y < yBorder)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + ySpeed);
        }
        if (Input.GetKey(KeyCode.S) && transform.position.y > -yBorder)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - ySpeed);
        }
    }
}
