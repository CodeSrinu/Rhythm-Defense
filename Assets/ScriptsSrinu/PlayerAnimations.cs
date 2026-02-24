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
        animator.SetTrigger("leftLegUp");
    }

    public void LeftHandUp()
    {
        animator.SetTrigger("leftHandUp");
    }

    public void RightHandUp()
    {
        animator.SetTrigger("rightHandUp");
    }
    public void RightLegUp()
    {
        animator.SetTrigger("rightLegUp");
    }

    public void HandsBack()
    {
        animator.SetTrigger("handsBack");
    }

    public void HandsFront()
    {
        animator.SetTrigger("handsFront");
    }

    public void LLRH()
    {
        animator.SetTrigger("LLRH");
    }

    public void RLLH()
    {
        animator.SetTrigger("RLLH");
    }
}
