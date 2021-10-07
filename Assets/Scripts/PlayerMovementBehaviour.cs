using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovementBehaviour : MonoBehaviour
{
    [Header("Player Movement")]
    [SerializeField] 
    private float fMovementSpeed = 0.0f;
    private Rigidbody2D mRigidbody2D;

    void Start()
    {
        mRigidbody2D = GetComponent<Rigidbody2D>();
        mRigidbody2D.drag = 3;
        mRigidbody2D.gravityScale = 0.0f;
        mRigidbody2D.freezeRotation = true;
    }

    void Update()
    {
        Movement();
    }

    void Movement()
    {
        float fInputX = Input.GetAxis("Horizontal");
        float fInputY = Input.GetAxis("Vertical");
        mRigidbody2D.velocity = new Vector2(fInputX * fMovementSpeed, fInputY * fMovementSpeed);
    }
}
