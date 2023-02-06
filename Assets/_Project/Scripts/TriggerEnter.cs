using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEnter : MonoBehaviour
{
    public string tag = "Player";
    public UnityEvent onEnter;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == tag)
        {
            onEnter.Invoke();
        }
    }
}
