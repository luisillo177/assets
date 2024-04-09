using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class movement : MonoBehaviour
{
    public float velocidad = 5f; // Velocidad de movimiento del objeto
    public Vector3 direccion = Vector3.right; // Dirección en la que se moverá el objeto

    // Método que se llama en cada frame
    void Update()
    {
        // Calculamos el desplazamiento basado en la dirección y la velocidad
        Vector3 desplazamiento = direccion * velocidad * Time.deltaTime;

        // Movemos el objeto en la dirección calculada
        transform.Translate(desplazamiento);
    }
}