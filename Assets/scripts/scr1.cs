using UnityEngine;

public class scr1 : MonoBehaviour
{
    public Animator Animator;

    public void OnButtonPress()
    {
        bool isActivated = Animator.GetBool("Activated");

        Animator.SetBool("Activated", !isActivated);
    }
}

