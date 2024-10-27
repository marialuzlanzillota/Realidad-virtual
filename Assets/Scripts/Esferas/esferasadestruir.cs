using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class esferasadestruir : MonoBehaviour
{
    public GameObject ObjPuntos;


    private void OnTriggerEnter(Collider other)
    {
        
            ObjPuntos.GetComponent<Puntos>().puntos += 1;
            Debug.Log("La pelota se destruye :)");
            Destroy(gameObject);
            Debug.Log("Si la pelota se destruye yo me sumo");


    } 
}
