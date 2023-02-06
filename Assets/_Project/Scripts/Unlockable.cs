using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unlockable : MonoBehaviour
{
    public Collider2D collider;
    public bool IsLocked = true;
    public void SetLocked(bool locked)
    {
        IsLocked = locked;
    }
    public void TryOpen()
    {
        if(IsLocked == false)
        {
            collider.enabled = false;
        }
    }
}
