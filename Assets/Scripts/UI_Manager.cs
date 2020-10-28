using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    [SerializeField]
    private GameObject _inventory;
    [SerializeField]
    private GameObject _pickupText;
    public bool inventoryIsOpen = false;
    [SerializeField]
    private Text _goldText;
    [SerializeField]
    private AudioSource _coins;
   

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

    public void PickupTextOn()
    {
        _pickupText.SetActive(true);
    }
        public void PickupTextOff()
    {
        _pickupText.SetActive(false);
    }

    public void PickupGold(int currentGold)
    {
        _goldText.text = "" + currentGold;
        _coins.Play();
    }
}
