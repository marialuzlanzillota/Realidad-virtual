using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EntreEscenas : MonoBehaviour
{
    private int Length;

    private void Awake()
    {
        var noDestruirEntreEscenas = FindObjectOfType < EntreEscenas>();
        if (noDestruirEntreEscenas.Length > 1)
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
    }


}
