using System;
using UnityEngine;

public class Mensajeprincipio : MonoBehaviour
{
    public Animator cartelAnim;
    public FirstPlayer player;
    private void OnTriggerEnter(Collider other)
    {
        cartelAnim.Play("open");
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        if(player == null ) player = FindObjectOfType<FirstPlayer>();
        if (player != null) player.playerCanNotMoveNow = true;
    }

    public void DesactivateObject()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        if (player != null) player.playerCanNotMoveNow = false;
    }
}
