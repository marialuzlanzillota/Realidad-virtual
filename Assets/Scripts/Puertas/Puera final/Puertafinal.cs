using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ControlPuntosPuerta : MonoBehaviour
{
    public Animator doorAnim2;
    public Animator panel;
    public Puntos puntosScript;      
    public puerta1 puertaScript;
    public TextMeshProUGUI texto;

    private bool puertaAbierta = false;
    private void Start()
    {
        puertaScript.enabled = false;
        Debug.Log("Te faltan esferas");
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger activation");
        if(other.gameObject.CompareTag("Player"))
        {
            if (puertaAbierta || CheckForDoorOpen())
            {
                doorAnim2.Play("open1");
            }
            else if (!CheckForDoorOpen())
            {

                StartCoroutine(OpenAndCloseDoor());
            }
        }
    }

    bool CheckForDoorOpen()
    {
        Debug.Log("CheckForDoorOpen");
        if (puntosScript.puntos >= 6 && !puertaAbierta)
        {
            puertaScript.enabled = true;
            puertaAbierta = true;
            Debug.Log("¡Puntos suficientes! Ahora puedes abrir la puerta.");
            return true;
        }
        return false;
    }

    private IEnumerator OpenAndCloseDoor()
    {
        Debug.Log("Coroutine");
        panel.Play("open");
        yield return new WaitForSeconds(5);
        panel.Play("close");
    }
}

