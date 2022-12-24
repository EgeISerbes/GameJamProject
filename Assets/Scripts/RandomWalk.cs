using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomWalk : MonoBehaviour
{
    public Rigidbody2D rb;
    public float accelerationTime = 2f;
    public float maxSpeed = 3f;
    private Vector2 movement;
    private float timeLeft;
    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            movement = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
            timeLeft += accelerationTime;
            print(movement);
        }
    }

    void FixedUpdate()
    {
       rb.velocity = Vector2.zero;
       rb.AddForce(movement * maxSpeed);
    }
}
