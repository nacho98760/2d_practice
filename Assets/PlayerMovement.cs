using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float jumpForce = 5f;

    Rigidbody2D rigidBody;

    public GameObject Pipe;

    public GameManagerScript GameManager;

    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        GameManager = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManagerScript>();
    }


    private void Update()
    {
        Jump();
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidBody.linearVelocity = Vector2.up * jumpForce;
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameManager.gameOver();
        Destroy(gameObject);
    }
}