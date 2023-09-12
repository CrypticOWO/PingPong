using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddlemovement : MonoBehaviour
{
    public float ySpeed = 0.00000000000001f;
    public float yUpBorder = 7.5f;
    public float yDownBorder = -7.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) && transform.position.y < yUpBorder)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + ySpeed);
        }
        if (Input.GetKey(KeyCode.DownArrow) && transform.position.y > yDownBorder)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - ySpeed);
        }
    }
}
