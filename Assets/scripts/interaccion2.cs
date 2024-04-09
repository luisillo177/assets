using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interaccion2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject panel;
    void Start()
    {
        PanelOff();
    }

    // Update is called once per frame
    public void PanelOn()
    {
        panel.SetActive(true);

    }

    public void PanelOff()
    {
        panel.SetActive(false);

    }

    void OnTriggerEnter(collider other)
    {
        if(other.CompareTag("Player"))
        { 
            PanelOn();
        }
    }
    void OnTriggerExit (collider other)
    {
        PanelOff();
    }
   

}
