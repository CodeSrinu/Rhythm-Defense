using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Animator playerAnim;
    private bool leftLegUp = false;
    private bool leftHandUp = false;
    private bool rightLegUp = false;
    private bool rightHandUp = false;
    private bool handsBack = false;

    public Rigidbody playerRb;
    private bool isGrounded;

    public float moveForce = 10f;
    public float jumpForce = 15f;


    private void Start()
    {
        playerAnim = GetComponent<Animator>();
        playerRb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        GetKeys();

    }

    private void FixedUpdate()
    {
        PlayerActions();
    }


    private void PlayerActions()
    {
        if(leftLegUp && rightHandUp)
        {
            //playerAnim.LLRH();
            MoveForward();
            ResetKeys();
        }
        else if (rightLegUp && leftHandUp)
        {
            //playerAnim.RLLH();
            MoveForward();
            ResetKeys();
        }
        else if (leftHandUp && rightHandUp)
        {
            //playerAnim.HandsFront();
            Jump();
            ResetKeys();
        }
        else if (handsBack)
        {
            //playerAnim.HandsBack();
            Slide();
            ResetKeys();
        }
        else if (leftHandUp)
        {
            //playerAnim.LeftHandUp();
            TurnLeft();
            ResetKeys();
        }
        else if (rightHandUp)
        {
            //playerAnim.RightHandUp();
            TurnRight();
            ResetKeys();
        }
    }

    private void MoveForward()
    {
        if (isGrounded)
        {
            playerRb.AddForce(transform.right * moveForce, ForceMode.Impulse);
        }
    }

    private void Jump()
    {
        if (isGrounded)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
    }

    private void Slide()
    {
        playerRb.AddForce(Vector3.right * moveForce , ForceMode.Impulse);
        playerAnim.SetTrigger("isSliding");

    }

    private void TurnLeft()
    {
        transform.Rotate(0, -90, 0);
        playerRb.velocity = Vector3.zero;
    }

    private void TurnRight()
    {
        transform.Rotate(0, 90, 0);
        playerRb.velocity = Vector3.zero;

    }


    private void GetKeys()
    {

        if (Input.GetKeyDown(KeyCode.W))
        {
            leftLegUp = true;
            rightHandUp = true;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            leftHandUp = true;
        }

        if(Input.GetKeyDown(KeyCode.S))
        {
            rightLegUp = true;
            leftHandUp = true;
        }

        if(Input.GetKeyDown (KeyCode.D))
        {
            rightHandUp = true;
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            rightHandUp = true;
            leftHandUp = true;
        }

        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            handsBack = true;
        }  

    }

    private void ResetKeys()
    {
      leftLegUp = false;
      leftHandUp = false;
      rightLegUp = false;
      rightHandUp = false;
      handsBack = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}
