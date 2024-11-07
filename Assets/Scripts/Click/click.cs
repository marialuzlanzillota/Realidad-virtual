using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class click : MonoBehaviour
{
    public Animator Esfera;
    private void OnMouseDown()
    {
        Esfera.Play("abajo");
        StartCoroutine(CargarEscenaConRetraso());
        Debug.Log("Click");
    }
    private IEnumerator CargarEscenaConRetraso()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(2);
    }
}
