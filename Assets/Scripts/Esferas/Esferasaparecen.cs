using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esferasaparecen : MonoBehaviour
{
    public Animator Esferas;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //Debug.Log("VOY A APARECER");
            Esferas.Play("esferassi");

        }

    }
}