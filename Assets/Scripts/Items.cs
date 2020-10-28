using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Items : MonoBehaviour
{
    private UI_Manager ui_manager;
    private Player player;

    // Start is called before the first frame update
    void Start()
    {
        ui_manager = GameObject.Find("Canvas").GetComponent<UI_Manager>();
        player = GameObject.Find("MyPlayer").GetComponent<Player>();
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
            
            if (Input.GetKeyDown(KeyCode.E))
            {
                ui_manager.PickupGold(GoldAmount());
                Destroy(this.gameObject);
                ui_manager.PickupTextOff();
            }
        }
    }
    void OnTriggerExit(Collider other) 
    {
        if (other.tag == "Player")
        {
            ui_manager.PickupTextOff();
        }
    }

    public int GoldAmount()
    {
        int randomAmt = Random.Range(10, 51);
        player.goldCount += randomAmt;
        return player.goldCount;
    }

}
