using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class npc : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("¡El NPC ha detectado al jugador!");
            // Aquí puedes poner la lógica para la interacción del NPC con el jugador
        }
    }
}