using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class final : MonoBehaviour
{
    public GameObject player; 
    


    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Final"); 
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); 
            
            //player.SetActive(false); 

        }
    }
}
