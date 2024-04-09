using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaccion : MonoBehaviour
{
    public float distanciaInteraccion = 3f; // Distancia a la que el jugador puede interactuar con el NPC
    private bool jugadorCerca = false; // Estado de si el jugador está cerca del NPC

    // Método que se llama en cada frame
    void Update()
    {
        // Verifica si el jugador está lo suficientemente cerca del NPC para interactuar
        if (jugadorCerca && Input.GetKeyDown(KeyCode.E))
        {
            Interactuar();
        }
    }

    // Método que se llama cuando otro collider entra en el trigger del NPC
    private void OnTriggerEnter(Collider other)
    {
        // Verifica si el collider que entró es el del jugador
        if (other.CompareTag("Player"))
        {
            jugadorCerca = true;
        }
    }

    // Método que se llama cuando otro collider sale del trigger del NPC
    private void OnTriggerExit(Collider other)
    {
        // Verifica si el collider que salió es el del jugador
        if (other.CompareTag("Player"))
        {
            jugadorCerca = false;
        }
    }

    // Método para interactuar con el NPC
    private void Interactuar()
    {
        // Aquí puedes agregar la lógica para la interacción con el NPC
        Debug.Log("¡Interactuando con el NPC!");
    }
}