using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionPlayParticles : MonoBehaviour
{
    [SerializeField] private ParticleSystem vfx;
    public void Do()
    {
        if (vfx)
        {
            vfx.Stop();
            vfx.Clear();
            vfx.Play();
        }
    }
}