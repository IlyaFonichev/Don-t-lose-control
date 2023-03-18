using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 10f;

    private Rigidbody2D _rigidBody;

    private void Start()
    {
        _rigidBody = gameObject.GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        Vector2 direction = new Vector2(moveHorizontal, 0);

        move(direction);
    }

    private void move(Vector2 direction)
    {
        _rigidBody.velocity = direction.normalized * speed;
    }
}
