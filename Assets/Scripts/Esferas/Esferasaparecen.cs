using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esferasaparecen : MonoBehaviour
{
    public Animator Esferas;
    public AudioSource Esfrasaparecen;
    private bool yaReprodujo = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //Debug.Log("VOY A APARECER");
            Esferas.Play("esferassi");
            if (!yaReprodujo && other.CompareTag("Player")) 
            {
                Esfrasaparecen.Play(); 
                yaReprodujo = true; 
            }
            
            
        }

    }
}