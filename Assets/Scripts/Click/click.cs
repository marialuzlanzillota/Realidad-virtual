using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class click : MonoBehaviour
{
    public Animator Esfera;
    public AudioSource boton;
    private void OnMouseDown()
    {
        Esfera.Play("abajo");
        boton.Play();
        StartCoroutine(CargarEscenaConRetraso());
        Debug.Log("Click");
    }
    private IEnumerator CargarEscenaConRetraso()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(2);
    }
}
