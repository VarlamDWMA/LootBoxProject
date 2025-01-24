using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionAnimatorTrigger : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private string triggerName;
    public void Do()
    {
        if (animator)
        {
            animator.SetTrigger(triggerName); ;
        }
    }
}
