using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float startingSpeed;

    // Start is called before the first frame update
    void Start()
    {
        bool isRight = UnityEngine.Random.value >= 0.5;
        float xVelocity = -1.0f;

        if(isRight)
        {
            xVelocity = 1.0f;
        }

        float yVelocity = UnityEngine.Random.Range(-1, 1);
        rb.velocity = new Vector2(xVelocity * startingSpeed, yVelocity * startingSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Respawn")
        {
            gameObject.transform.position = new Vector2(0, 0);
        }
    }
}
