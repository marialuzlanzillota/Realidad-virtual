using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class naranja : MonoBehaviour
{
    public Animator esferanaranja;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            esferanaranja.Play("si");
        }


    }
}
