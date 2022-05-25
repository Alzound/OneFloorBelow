using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Audio")]
    public AudioClip[] audios; 
    AudioSource audioSource;
    public AudioSource audioS;
    public AudioClip bulb, door; 
    [Space(10)]
    [Header("Animator")]
    Animator anim; 
    [Space(10)]
    [Header("References")]
    public GameObject trigger;
    public GameObject FR_Teleport;
    public GameObject Calm_Teleport;
    public GameObject elevator;

    [Header("Player")]
    public GameObject player;

     
    [Header("Booleans")]
    public bool command, fall = false; 
    [Header("int values")]
    public int audioNum; 

    // Start is called before the first frame update
    void Start()
    {
        //audios = new AudioClip[7];

        audioSource = GetComponent<AudioSource>(); 

        anim = gameObject.GetComponent<Animator>();
    

    }

    // Update is called once per frame
    void Update()
    {
        FirstRoomCheck(); 
        if(command == true)
        {
            PlayOnCommand();
        }
        if(fall == true)
        {
            anim.SetBool("down", true);
        }
         
        Debug.Log(audioNum); 
    }

    
     void FirstRoomCheck()
	{
        if(audioSource.isPlaying)
        {
            anim.SetBool("primer", true); 
        }
        if(trigger.GetComponent<TriggerCheck>().entro == true)
		{
            /*
            audioSource.Stop();
            if(!audioSource.isPlaying)
			{
                audioNum = 1; 
                
            }
            */
            
            anim.SetBool("FR_Sequence", true); 
            trigger.GetComponent<TriggerCheck>().entro = false; 
		}
	}
    

        
//Audio Control
    void PlayOnCommand()
    {
        if(!audioSource.isPlaying)
        {
            switch(audioNum)
            {
                
                case 0:
                {
                    
                     
                    

                        
                    
                }break;
                case 1:
                {
                    audioSource.Stop(); 
                    if(!audioSource.isPlaying)
                    {
                        
                        //Primer Piso - Glitch
                        audioSource.clip = audios[1];
                        audioSource.Play();
                         
                    }
                    command = false; 
                        
                    
                }break; 
                case 2:
                {
                    audioSource.Stop(); 
                    if(!audioSource.isPlaying)
                    {
                        // Calma - Glitch
                        audioSource.clip = audios[2];
                        audioSource.Play();
                        command = false; 
                    }
                    
                        
                }break; 
                case 3:
                {
                    audioSource.Stop(); 
                    if(!audioSource.isPlaying)
                    {
                        //Segundo Piso - Glitch
                        audioSource.clip = audios[3];
                        audioSource.Play();
                        Debug.Log("3ro");
                        command = false; 
                    }
                    
                }break; 
                case 4:
                {
                    audioSource.Stop(); 
                    if(!audioSource.isPlaying)
                    {
                        //Tercer Piso - Glitch
                        anim.SetBool("tercero", true);
                        audioSource.clip = audios[4];
                        audioSource.Play();
                        Debug.Log("4to");
                        command = false;
                    }
                     
                }break; 
                case 5:
                {
                    audioSource.Stop(); 
                    if(!audioSource.isPlaying)
                    {
                        //Ultimo Piso - Glitch
                        anim.SetBool("Ultimo", true);
                        audioSource.clip = audios[5];
                        audioSource.Play();
                        command = false;
                    }
                    
                    StartCoroutine(WaitAudio()); 
                     
                }break; 
                case 6:
                {
                    audioSource.Stop(); 
                    if(!audioSource.isPlaying)
                    {
                        
                        //Primer Piso - Glitch
                        audioSource.clip = audios[6];
                        audioSource.Play();
                        command = false; 
                    }
                     
                }break; 
            }
        }
         
    }

    IEnumerator WaitAudio()
    {
        Debug.Log("wait audio");
        
        
        yield return new WaitForSeconds(audioSource.clip.length);
        audioSource.Stop(); 
        audioSource.clip = audios[6];
        audioSource.Play();
    }




    void Transition()
    {
        Debug.Log("Cambio"); 
        player.transform.position = Calm_Teleport.transform.position;
        command = true; 
        audioNum = 2;   
    }

    void ReturnTransition()
    {
        player.transform.position = FR_Teleport.transform.position;
        elevator.GetComponent<Elevator>().num = 2; 

    }

    public void PlayBrokenSound()
    {
        audioS.PlayOneShot(bulb);
    }

    public void PlayOpenSound()
    {
        audioS.PlayOneShot(door);
    }
}
