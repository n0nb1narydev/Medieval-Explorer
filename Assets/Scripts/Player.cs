using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    CharacterController _cc;
    [SerializeField]
    private float _speed = 3.5f;
    private float _gravity = 1f;
    private float _yVelocity;
    private UI_Manager ui_manager;
    [SerializeField]
    public int goldCount = 0;
    [SerializeField]
    private AudioSource _steps;

    // Start is called before the first frame update
    void Start()
    {
        _cc = GetComponent<CharacterController>();
        ui_manager = GameObject.Find("Canvas").GetComponent<UI_Manager>();
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        ui_manager.FirstQuest(goldCount);
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            ui_manager.Inventory();
        }
        
        MovePlayer();

        if (_cc.isGrounded==true && _cc.velocity.magnitude > 2f && _steps.isPlaying == false)
        {
            _steps.Play();
        }
    }

    private void MovePlayer() 
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical"); 


        Vector3 direction = new Vector3(horizontalInput, 0 , verticalInput);
        Vector3 velocity = _speed * direction;
        velocity.y = _yVelocity;
        _yVelocity -= _gravity; 

        velocity = transform.transform.TransformDirection(velocity);

        _cc.Move(velocity * Time.deltaTime);
    }

    

}
