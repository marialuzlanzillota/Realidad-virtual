using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puerta1 : MonoBehaviour
{
    public Animator doorAnim;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //Debug.Log("VOY A ABRIRME");
            doorAnim.Play("open1");

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //Debug.Log("VOY A CERRAR");
            doorAnim.Play("close1");
        }

    }
}
