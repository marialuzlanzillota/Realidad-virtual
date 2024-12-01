using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class azul : MonoBehaviour
{
    public Animator esferazul;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            esferazul.Play("si");
        }
    }
}
