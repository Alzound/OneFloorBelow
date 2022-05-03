using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations; 

public class Trigger : MonoBehaviour
{
    public Animator room_Anim;
    public GameObject player; 
  
    public GameObject trigger;
    public AudioSource audi, audi2;
    public GameObject destination; 
    
    public float time; 


    // Start is called before the first frame update
    void Start()
    {
        room_Anim = gameObject.GetComponent<Animator>();
    }

	private void Update()
	{
        FirstCheck();
        SecondCheck();
	}


    void FirstCheck()
	{
        if(audi.isPlaying)
        {
            room_Anim.SetBool("puerta", true); 
        }
	}

    void SecondCheck()
    {
         if(trigger.GetComponent<TriggerCheck>().entro == true)
		{

            audi.Stop();
            if(!audi2.isPlaying)
			{
                audi2.Play();
            }
            
            room_Anim.SetBool("FR_Sequence", true); 
		}
    }

    void Transition()
    {
        player.transform.position = destination.transform.position; 
    }
   
}
