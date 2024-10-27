using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puerta1 : MonoBehaviour
{
    public Animator doorAnim;
    public AudioSource puertaabre;
    public AudioSource puertacierra;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //Debug.Log("VOY A ABRIRME");
            doorAnim.Play("open1");
            puertaabre.Play();

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //Debug.Log("VOY A CERRAR");
            doorAnim.Play("close1");
            puertacierra.Play();
        }

    }
}
