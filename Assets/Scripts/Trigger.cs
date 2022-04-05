using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations; 

public class Trigger : MonoBehaviour
{
    public Animator anim;
    public GameObject trigger;
    public AudioSource audi, audi2;
    
    
    public float time; 


    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        
    }

	private void Update()
	{
        Check();
	}


	void ExitGame()
	{
        Debug.Log("Exit"); 
        Application.Quit(); 
	}

    void Check()
	{
        if(trigger.GetComponent<TriggerCheck>().entro == true)
		{
            audi.Stop();
            if(!audi2.isPlaying)
			{
                audi2.Play();
            }
            
            anim.SetBool("final", true); 
		}
	}
}
