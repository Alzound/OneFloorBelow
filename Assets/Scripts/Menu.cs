using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    Canvas can;  
    public GameObject player, mainmenuB, AxisButton, volumeS, returnB, title;
    public AudioSource game_Audio; 
  

    private void Start() 
    {
        can = this.gameObject.GetComponent<Canvas>();
        //game_Audio = GetComponent<AudioSource>(); 
    }

    public void Play()
    {
        title.SetActive(false); 
        player.SetActive(true);
        game_Audio.enabled = true;
        can.enabled = false; 
    }

    public void Options()
    {
        AxisButton.SetActive(true);
        volumeS.SetActive(true);
        returnB.SetActive(true);
        mainmenuB.SetActive(false);
        
    }

    public void returnOpt()
	{
        mainmenuB.SetActive(true);

        volumeS.SetActive(false);
        returnB.SetActive(false); 
        AxisButton.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit(); 
    }
}
