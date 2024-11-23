using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ControlPuntosPuerta : MonoBehaviour
{
    public Animator doorAnim2;
    public Animator image;
    public Puntos puntosScript;      
    public TextMeshProUGUI texto;
    public AudioSource puertaabre;
    public AudioSource puertacierra;

    private bool puertaAbierta = false;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger activation");
        if(other.gameObject.CompareTag("Player"))
        {
            if (puertaAbierta || CheckForDoorOpen())
            {
                doorAnim2.Play("open1");
                puertaabre.Play();
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
            puertaAbierta = true;
            Debug.Log("¡Puntos suficientes! Ahora puedes abrir la puerta.");
            return true;
        }
        return false;
    }

    private IEnumerator OpenAndCloseDoor()
    {
        Debug.Log("Coroutine");
        image.Play("open");
        puertaabre.Play();
        yield return new WaitForSeconds(3);
        image.Play("close");
        puertacierra.Play();
    }
}

