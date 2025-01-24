using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestAnimation : MonoBehaviour
{
    public Animator Chest; 
   
    public void Open ()
    {
        Chest.SetTrigger("Open");
        Debug.Log("Open");
    }

    public void Close()
    {
        Chest.SetTrigger("Close");
        Debug.Log("Close");
    }
}
