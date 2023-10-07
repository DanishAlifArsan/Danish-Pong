using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUPaddleSpeed : MonoBehaviour
{
    // Start is called before the first frame update
    public Collider2D ball;
    public PaddleController[] paddle;
   public int multiplier;

   public PowerUpManager manager;
    private void OnTriggerEnter2D(Collider2D other) {
        if (other == ball)
        {
            foreach (var p in paddle)
            {
                p.ChangeSpeed(multiplier);   
            }
            manager.RemovePowerUp(gameObject);
        }
    }
}
