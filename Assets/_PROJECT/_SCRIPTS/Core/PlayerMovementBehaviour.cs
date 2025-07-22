//-----------------------------------------------------------
// (C) 2025 Abdulrhman Al-Ghamdi
//
// Summary:
// A Unity MonoBehaviour that implements basic horizontal movement
// and jumping for a 2D platformer character. It uses Rigidbody2D
// physics and input polling inside Unity's Update loop.
// This script requires no other external scripts or systems.
//
// Namespace: OFF_BOX_Studios
// Created by: Abdulrhman Al-Ghamdi
//-----------------------------------------------------------

using UnityEngine;

namespace OFF_BOX_Studios
{
    /// <summary>
    /// Handles basic 2D movement for a platformer player character.
    /// Applies horizontal motion and jump logic using Rigidbody2D.
    /// </summary>
    [RequireComponent(typeof(Rigidbody2D))]
    public class PlayerMovementBehaviour : MonoBehaviour
    {
        [SerializeField] private float moveSpeed = 5f;
        [SerializeField] private float jumpForce = 10f;

        private Rigidbody2D rigidBody;
        private bool isGrounded;

        private void Awake()
        {
            rigidBody = GetComponent<Rigidbody2D>();
        }

        private void Update()
        {
            Move();
            HandleJump();
        }

        private void Move()
        {
            float inputX = Input.GetAxisRaw("Horizontal");
            rigidBody.linearVelocity = new Vector2(inputX * moveSpeed, rigidBody.linearVelocity.y);
        }

        private void HandleJump()
        {
            if (Input.GetButtonDown("Jump") && isGrounded)
            {
                rigidBody.linearVelocity = new Vector2(rigidBody.linearVelocity.x, jumpForce);
            }
        }

        private void OnCollisionEnter2D(Collision2D collision)
        {
            isGrounded = true;
        }

        private void OnCollisionExit2D(Collision2D collision)
        {
            isGrounded = false;
        }
    }
}

//-----------------------------------------------------------
// Summary:
// A Unity MonoBehaviour that implements basic horizontal movement
// and jumping for a 2D platformer character. It uses Rigidbody2D
// physics and input polling inside Unity's Update loop.
// This script requires no other external scripts or systems.
//-----------------------------------------------------------
