using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opciones : MonoBehaviour
{
    public GameObject pantallaOpciones;
    bool activated;

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
        activated = !activated;

        if (pantallaOpciones == null) pantallaOpciones = FindObjectOfType<brillo>().optionsPanel;

        if (pantallaOpciones != null)
        {
            pantallaOpciones.SetActive(activated);
            Cursor.visible = activated;
            if (activated) Cursor.lockState = CursorLockMode.None;
            else Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
