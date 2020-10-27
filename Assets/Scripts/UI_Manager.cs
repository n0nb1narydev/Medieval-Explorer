using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    [SerializeField]
    private GameObject _inventory;
    public bool inventoryIsOpen = false;

    private
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Inventory()
    {
        if (inventoryIsOpen)
        {
            _inventory.SetActive(false);
            inventoryIsOpen = false;
        }
        else
        {
            _inventory.SetActive(true);
            inventoryIsOpen = true;
        
}
    }
}
