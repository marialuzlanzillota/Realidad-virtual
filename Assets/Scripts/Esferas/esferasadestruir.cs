using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class esferasadestruir : MonoBehaviour
{
    public GameObject ObjPuntos;
    public AudioSource Agarraesferas;
    public AudioSource brillo;

    private void Start()
    {
        brillo.Play();
    }
    private void OnTriggerEnter(Collider other)
    {
        
            ObjPuntos.GetComponent<Puntos>().puntos += 1;
            Debug.Log("La pelota se destruye :)");
            Debug.Log("Si la pelota se destruye yo me sumo");
            Agarraesferas.Play();
            brillo.Stop();
        Destroy(gameObject);

    } 
}
