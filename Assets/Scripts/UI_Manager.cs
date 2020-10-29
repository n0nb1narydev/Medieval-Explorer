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
    [SerializeField]
    private AudioSource _bag;
    [SerializeField]
    private Text _questObjective;
    [SerializeField]
    private Text _questProgress;

    private Player player;
    private bool questComplete = false;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("MyPlayer").GetComponent<Player>();
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
            _bag.Play();
        }

        else
        {
            _inventory.SetActive(true);
            inventoryIsOpen = true;
            _bag.Play();
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

    public void FirstQuest(int currentGold)
    {
        if (currentGold <= 150)
        {
            _questObjective.text = "Collect at least 150 gold coins.";
            _questProgress.text = currentGold + "/150";
        }
        else
        {
            _questProgress.text = "COMPLETE!";
            questComplete = true;
        }
    }

    // public void SecondQuest(bool armorFound)
    // {
    //     if (armorFound == false)
    //     {
    //         _questObjective.text = "Find 3 pieces of armor.";
    //         _questProgress.text = currentArmor + "/3";
    //         questComplete = false;
    //     }
    //     else
    //     {
    //         _questProgress.text = "COMPLETE!";
    //         questComplete = true;
    //     }
    // }
}
