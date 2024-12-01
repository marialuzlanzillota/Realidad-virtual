using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rosa : MonoBehaviour
{
    public Animator esferarosa;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            esferarosa.Play("si");
        }


    }
}
