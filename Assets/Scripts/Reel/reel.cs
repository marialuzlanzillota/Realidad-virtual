using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class reel : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            StartCoroutine(CargarEscenaConRetraso());
        }
    }
    private IEnumerator CargarEscenaConRetraso()
    {
        yield return new WaitForSeconds(2); 
        SceneManager.LoadScene(2); 
    }

}
