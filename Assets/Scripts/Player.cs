using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; 

public class Player : MonoBehaviour
{
    Keyboard keyboard;
    Mouse mouse;
    Gamepad gamepad; 

    // Start is called before the first frame update
    void Start()
    {
        prepare();  
    }

    public void prepare()
    {
        keyboard = Keyboard.current;
        mouse = Mouse.current;
        gamepad = Gamepad.current; 
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();
    }

    public void CheckInput()
    {
        if (keyboard.wKey.wasPressedThisFrame)
        {
            print("Holo"); 
        }
    }
    public void Jump()
    {
        if(keyboard.spaceKey.wasPressedThisFrame)
        {
            print("jump");
        }
    }

 
}
