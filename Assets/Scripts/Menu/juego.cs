using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class juego : MonoBehaviour
{
    public void CambiarEscea()
    {
        SceneManager.LoadScene(1);
        Debug.Log("Cambio de escena");
    }
}
