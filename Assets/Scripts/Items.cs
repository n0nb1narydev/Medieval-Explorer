using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Items : MonoBehaviour
{
    private UI_Manager ui_manager;

    // Start is called before the first frame update
    void Start()
    {
        ui_manager = GameObject.Find("Canvas").GetComponent<UI_Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            ui_manager.PickupTextOn();
        }
    }
    void OnTriggerExit(Collider other) 
    {
        if (other.tag == "Player")
        {
            ui_manager.PickupTextOff();
        }
    }

}
