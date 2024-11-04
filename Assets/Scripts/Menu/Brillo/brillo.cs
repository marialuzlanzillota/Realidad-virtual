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
        slider.value = PlayerPrefs.GetFloat("brillo",0.5f);
        panelBrillo.color = new Color(panelBrillo.color.r, panelBrillo.color.g, panelBrillo.color.b, slider.value);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ChangeSlider(float valor)
    {
        slidersValue = valor;
        PlayerPrefs.SetFloat("brillo", slidersValue);
        panelBrillo.color=new Color (panelBrillo.color.r,panelBrillo.color.g,panelBrillo.color.b,slider.value);
    }   
}
