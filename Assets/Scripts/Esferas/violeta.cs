using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class violeta : MonoBehaviour
{
    public Animator esferavioleta;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            esferavioleta.Play("si");
        }
    }
}
