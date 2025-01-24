using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEventHandler : MonoBehaviour
{
    public ParticleSystem particleSystem;

    public void PlayParticles()
    {
        if (particleSystem != null)
        {
            particleSystem.Play();
        }
    }
}
