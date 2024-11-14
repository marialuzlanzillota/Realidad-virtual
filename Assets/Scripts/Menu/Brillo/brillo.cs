using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class brillo : MonoBehaviour
{
    public Slider slider;
    public float slidersValue;
    public Image panelBrillo;
    public GameObject optionsPanel;

    void Start()
    {
        slider.minValue = 0.1f;
        slider.maxValue = 1f;


        slider.value = PlayerPrefs.GetFloat("brillo", 0.5f);

        panelBrillo.color = new Color(panelBrillo.color.r, panelBrillo.color.g, panelBrillo.color.b, 1 - slider.value);
    }

    public void ChangeSlider(float valor)
    {
        slidersValue = valor;
        PlayerPrefs.SetFloat("brillo", slidersValue);

        // Invertir el valor para cambiar brillo en la dirección correcta
        panelBrillo.color = new Color(panelBrillo.color.r, panelBrillo.color.g, panelBrillo.color.b, 1 - slider.value);
    }
}
