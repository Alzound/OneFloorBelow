using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; 
using UnityEngine.EventSystems; 

public class Elevator : MonoBehaviour
{
    public int num = 0;  

    public Animator anim;   

    public Material mat, newMat;  

    // Start is called before the first frame update
    void Start()
    {
        
    } 
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("player"))
        {
            switch(num)
            {
                case 2: 
                {
                    anim.SetBool("segundo", true);
                }
                break;
                case 3: 
                {
                    anim.SetBool("tercero", true);
                }
                break;
                case 4: 
                {
                    anim.SetBool("cuarto", true);
                }
                break; 
            }

        }    
    }
}
