using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public int speed; 
    public KeyCode upKey; 
    public KeyCode downKey; 
    private Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       MoveObject(GetInput());
    }

    private Vector2 GetInput() {
        if (Input.GetKey(upKey))
        {
            return Vector2.up * speed;
        }
        if (Input.GetKey(downKey))
        {
            return Vector2.down * speed;
        }

        return Vector2.zero;
    }

    private void MoveObject(Vector2 movement) {
        rigidbody.velocity = movement;
    }
}