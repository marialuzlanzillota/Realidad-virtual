using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mensajeprincipio : MonoBehaviour
{
    public Animator cartelAnim;
    private void OnTriggerEnter(Collider other)
    {
        cartelAnim.Play("open");
    }

    }
