using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ControlPuntosPuerta : MonoBehaviour
{
    public Animator doorAnim2;
    public Puntos puntosScript;      
    public puerta1 puertaScript;
    public TextMeshProUGUI texto;

    private bool puertaAbierta = false;
    private void Start()
    {
        puertaScript.enabled = false;
        Debug.Log("Te faltan esferas");
    }
    private void Update()
    {
        if (puntosScript.puntos >= 6 && !puertaAbierta)
        {
            puertaScript.enabled = true;
            puertaAbierta = true;
            Debug.Log("¡Puntos suficientes! Ahora puedes abrir la puerta.");
        }
        
     
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && puertaAbierta)
        {
            doorAnim2.Play("open1");
        }
        //else
        //{
        //    StartCoroutine(OpenAndCloseDoor());
        //}
    }

    //private IEnumerator OpenAndCloseDoor()
    //{
    //    doorAnim2.Play("open");
    //    yield return new WaitForSeconds(5);
    //    doorAnim2.Play("close");
    //}
}

