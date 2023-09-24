using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public Vector2 resetPosition;
    public Vector2 speed; 
    private Rigidbody2D rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        rigidbody.velocity = speed; 
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void ResetBall() 
    { 
        transform.position = new Vector3(resetPosition.x, resetPosition.y, 0); 
    }
}
