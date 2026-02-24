using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private PlayerAnimations playerAnim;
    public bool leftLegUp = false;
    public bool leftHandUp = false;
    public bool rightLegUp = false;
    public bool rightHandUp = false;
    public bool leftHandBack = false;
    public bool rightHandBack = false;


    private void Start()
    {
        playerAnim = GetComponent<PlayerAnimations>();
    }

    private void Update()
    {
        GetKeys();
        PlayerActions();
        ResetKeys();
    }


    private void PlayerActions()
    {
        if(leftLegUp && rightHandUp)
        {
            playerAnim.LeftHandUp();
            playerAnim.RightHandUp();
            MoveForward();
        }
        else if (rightLegUp && leftHandUp)
        {
            playerAnim.RightLegUp();
            playerAnim.LeftHandUp();
            MoveForward();
        }
        else if (leftHandUp && rightHandUp)
        {
            playerAnim.LeftHandUp();
            playerAnim.RightHandUp();
            Jump();
        }
        else if (leftHandBack && rightHandBack)
        {
            playerAnim.LeftHandBack();
            playerAnim.RightHandBack();
            Slide();
        }
        else if (leftHandUp)
        {
            playerAnim.LeftHandUp();
            TurnLeft();
        }
        else if (rightHandUp)
        {
            playerAnim.RightHandUp();
            TurnRight();
        }
    }





    private void MoveForward()
    {
        //move
    }

    private void Jump()
    {
        //jump
    }

    private void Slide()
    {
        //slide
    }

    private void TurnLeft()
    {
        //turn left
    }

    private void TurnRight()
    {
        //turn right
    }


    private void GetKeys()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {
            leftLegUp = true;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            leftHandUp = true;
        }

        if(Input.GetKeyDown(KeyCode.D))
        {
            rightLegUp = true;
        }

        if(Input.GetKeyDown (KeyCode.F))
        {
            rightHandUp = true;
        }

        if(Input.GetKeyDown(KeyCode.W))
        {
            leftHandBack = true;
        }

        if(Input.GetKeyDown(KeyCode.E))
        {
            rightHandBack = true;
        }  

    }

    private void ResetKeys()
    {
        if (Input.GetKeyUp(KeyCode.A))
        {
            leftLegUp = false;
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            leftHandUp = false;
        }

        if (Input.GetKeyUp(KeyCode.D))
        {
            rightLegUp = false;
        }

        if (Input.GetKeyUp(KeyCode.F))
        {
            rightHandUp = false;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            leftHandBack = false;
        }

        if (Input.GetKeyUp(KeyCode.E))
        {
            rightHandBack = false;
        }
    }

}
