using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class celeste : MonoBehaviour
{
    public Animator esferaceleste;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            esferaceleste.Play("si");
        }


    }
}
