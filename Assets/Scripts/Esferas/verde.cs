using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class verde : MonoBehaviour
{
    public Animator esferaverde;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            esferaverde.Play("si");
        }
    }
}
