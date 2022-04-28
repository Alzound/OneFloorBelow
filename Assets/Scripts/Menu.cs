using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    Canvas can;  

    private void Start() 
    {
        can = this.gameObject.GetComponent<Canvas>();     
    }

    public void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
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
