using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PaddleController : MonoBehaviour
{
    public int speed; 
    public KeyCode upKey; 
    public KeyCode downKey; 
    private Rigidbody2D rigidbody;
    private bool isOnPU;
    private Vector2 tempScale;
    private int tempSpeed;
    private float durationCooldown = 0;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        isOnPU = false;
        tempScale =  transform.localScale;
        tempSpeed = speed;
    }

    // Update is called once per frame
    void Update()
    {
       MoveObject(GetInput());  
       if (isOnPU)
       {
            PUDuration(5);
       }
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
        // Debug.Log("TEST: " + movement); 
        rigidbody.velocity = movement;
    }

    public void ChangeSize(float multiplier)
    {
        if (!isOnPU)
        {
            transform.localScale = new Vector3(tempScale.x, tempScale.y * multiplier);
            isOnPU = true;
        }
    }
    public void ChangeSpeed(int multiplier)
    {
        if (!isOnPU)
        {
            speed *= multiplier;
            isOnPU = true;
        }
    }

    private void PUDuration(float duration) {
        durationCooldown += Time.deltaTime;
        if (durationCooldown >= duration)
        {
            isOnPU = false;
            durationCooldown = 0;
            RemovePUEffect();
        }
    }

    private void RemovePUEffect() {
        transform.localScale = tempScale;
        speed = tempSpeed;
    }
}
