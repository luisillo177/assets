using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class collider : MonoBehaviour
{
   
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
           
            gameObject.SetActive(false);
        }
    }
}