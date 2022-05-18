using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; 
using UnityEngine.EventSystems; 

public class Elevator : MonoBehaviour
{
    public int num = 0;  
    public GameManager manager; 
    public Animator anim;   

    public Material mat, newMat;  
    
    private void Start() {
        
    }
    
    private void Update() {
        num = manager.GetComponent<GameManager>().audioNum;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Entro al trigger"); 
            //Debug.Log(other); 
            //Debug.Log(num); 
            switch(num)
            {
                case 2: 
                {
                    Debug.Log("SEgundo piso"); 
                    anim.SetBool("segundo", true);
                    manager.GetComponent<GameManager>().audioNum = 3; 
                    manager.GetComponent<GameManager>().command = true;
                }
                break;
                case 3: 
                {
                    anim.SetBool("tercero", true);
                    manager.GetComponent<GameManager>().audioNum = 4;
                    manager.GetComponent<GameManager>().command = true; 
                }
                break;
                case 4: 
                {
                    manager.GetComponent<GameManager>().audioNum = 5; 
                    manager.GetComponent<GameManager>().command = true;
                    
                }
                break; 
            }

        }    
    }

    private void OnTriggerExit(Collider other) {
        if(manager.GetComponent<GameManager>().audioNum == 5)
        {
            manager.GetComponent<GameManager>().fall = true;
            Debug.Log("caida"); 
        }
    }


}

