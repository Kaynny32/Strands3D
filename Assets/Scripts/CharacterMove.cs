using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    [SerializeField]
    float speed;
    [SerializeField]
    float jump;
    [SerializeField]
    float gravity;
    [SerializeField]
    CharacterController _controller;

    float x_Move;
    float z_Move;
    Vector3 _moveDirecrion;

    void Update()
    {
        Move();
    }

    void Move()
    {
        x_Move = Input.GetAxis("Horizontal");
        z_Move = Input.GetAxis("Vertical");
        if (_controller.isGrounded)
        {
            _moveDirecrion = new Vector3(x_Move, 0f, z_Move);
            _moveDirecrion = transform.TransformDirection(_moveDirecrion);
            if (Input.GetKey(KeyCode.Space))
            {
                _moveDirecrion.y += jump;
            }
        }
        _moveDirecrion.y -= gravity;
        _controller.Move(_moveDirecrion * speed * Time.deltaTime);
    }
}
