using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Puntos : MonoBehaviour
{
    public int puntos=0;
    public TextMeshProUGUI textoPuntos; 


    private void Update()
    {
        textoPuntos.text = puntos + "/6";

    }
}
