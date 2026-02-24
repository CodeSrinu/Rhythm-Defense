using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void LeftLegUp()
    {
        animator.SetBool("leftLegUp", true);
    }

    public void LeftHandUp()
    {
        animator.SetBool("leftHandUp", true);
    }

    public void RightHandUp()
    {
        animator.SetBool("rightHandUp", true);
    }
    public void RightLegUp()
    {
        animator.SetBool("rightLegUp", true);
    }

    public void LeftHandBack()
    {
        animator.SetBool("leftHandBack", true);
    }

    public void RightHandBack()
    {
        animator.SetBool("rightHandBack", true);
    }
}
