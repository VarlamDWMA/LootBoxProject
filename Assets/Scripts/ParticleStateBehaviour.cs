using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleStateBehaviour : StateMachineBehaviour
{
    public ParticleSystem particleSystem;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        if (particleSystem != null)
        {
            particleSystem.Play();
        }
    }
}
