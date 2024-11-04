using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opciones : MonoBehaviour
{
    public GameObject pantallaOpciones;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            MostrarOpciones();
        }
    }

    public void MostrarOpciones()
    {
        if (pantallaOpciones == null) pantallaOpciones = FindObjectOfType<brillo>().optionsPanel;
        if (pantallaOpciones != null) pantallaOpciones.SetActive(true);
    }
}
