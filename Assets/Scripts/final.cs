using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class final : MonoBehaviour
{
    public GameObject player; 
    public Animator anim; 

    private void Start() {
        anim = GetComponent<Animator>(); 
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Final"); 
            anim.SetBool("credits", true);

        }
         
    }


    public void QuitS()
    {
         
        Application.Quit();
    }

    
}
