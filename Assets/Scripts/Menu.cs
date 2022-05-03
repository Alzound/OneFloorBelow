using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    Canvas can;  
    public GameObject player; 
    public AudioSource game_Audio; 
  

    private void Start() 
    {
        can = this.gameObject.GetComponent<Canvas>();
        //game_Audio = GetComponent<AudioSource>(); 
    }

    public void Play()
    {
        
        player.SetActive(true);
        game_Audio.enabled = true;
        can.enabled = false; 
    }

    public void Options()
    {

    }

    public void Quit()
    {
        Application.Quit(); 
    }
}
