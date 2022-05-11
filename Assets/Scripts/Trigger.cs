using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations; 

public class Trigger : MonoBehaviour
{
    public Animator room_Anim;
    public GameObject player; 
  
    public GameObject trigger;
    public AudioSource audi, audi2, audi3;
    public GameObject destination, returnDestination; 
    
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
        Debug.Log("Cambio"); 
        player.transform.position = destination.transform.position; 
        audi2.Stop(); 
        StartCoroutine(WaitForAudio());
    }
   
    IEnumerator WaitForAudio()
    {
        yield return new WaitForSeconds(15);

            if(!audi3.isPlaying)
			{
                audi3.Play();
            }
        Debug.Log("llega");
        yield return new WaitForSeconds(25); 
        player.transform.position = returnDestination.transform.position;  
        Debug.Log("Regreso"); 
    }

}
