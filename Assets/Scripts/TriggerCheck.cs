using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCheck : MonoBehaviour
{
    public bool entro = false;

    public GameManager manager;  
    // Start is called before the first frame update
    

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            entro = true; 
            manager.GetComponent<GameManager>().command = true; 
            manager.GetComponent<GameManager>().audioNum++; 

        }
    }

}
