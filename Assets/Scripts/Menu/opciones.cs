using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opciones : MonoBehaviour
{
    public ControladorOpciones panelOpciones;

    void Start()
    {
        panelOpciones = GameObject.FindWithTag("opciones").GetComponent<ControladorOpciones>();
    }

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
        panelOpciones.pantallaOpciones.SetActive(true);
    }
}
