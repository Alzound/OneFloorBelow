using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("Audio")]
    public AudioClip[] audios; 
    AudioSource audioSource;
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
    bool E_1, E_2, E_3; 
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
        PlayOnCommand(); 
    }


     void FirstRoomCheck()
	{
        if(audioSource.isPlaying)
        {
            anim.SetBool("primer", true); 
        }
        if(trigger.GetComponent<TriggerCheck>().entro == true)
		{
            audioSource.Stop();
            if(!audioSource.isPlaying)
			{
                audioNum = 1; 
            }
            
            anim.SetBool("FR_Sequence", true); 
		}
	}

        
//Audio Control
    void PlayOnCommand()
    {
        switch(audioNum)
        {
            case 0:
            {
                //Primer Piso
                audioSource.clip = audios[0];
                audioSource.Play();

            }break; 
            case 1:
            {
                audioSource.Stop(); 
                //Primer Piso - Glitch
                audioSource.clip = audios[1];
                audioSource.Play();
            }break; 
            case 2:
            {
                //Habitación de calma
                audioSource.clip = audios[2];
                audioSource.Play();
            }break; 
            case 3:
            {
                //Segundo piso
                audioSource.clip = audios[3];
            }break; 
            case 4:
            {
                //Tercer piso
                audioSource.clip = audios[4];
            }break; 
            case 5:
            {
                //Ultímo piso
                audioSource.clip = audios[5];
            }break; 
            case 6:
            {
                //Ultímo piso
                audioSource.clip = audios[6];
            }break; 
        }
         
    }

    void ElevatorWork()
    {
        if(E_1 == true)
        {
            
            //this.gameObject.GetComponent<MeshRenderer>().material = newMat;
            player.transform.parent = this.gameObject.transform;
            /*
            anim.SetBool("2", true);

            if(anim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1)
            {
                player.transform.SetParent(null);

            }
            */

        }
        else
        {
            //this.gameObject.GetComponent<MeshRenderer>().material = mat; 
        }
        if(E_2 == true)
        {
            //this.gameObject.GetComponent<MeshRenderer>().material = newMat;
            player.transform.parent = this.gameObject.transform;
            /*
            anim.SetBool("2", true);
            elevatorB.SetActive(false); 
            if(anim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1)
            {
                player.transform.SetParent(null);

            }
            */

        }
        else
        {
            //this.gameObject.GetComponent<MeshRenderer>().material = mat; 
        }
        if(E_3 == true)
        {
            //this.gameObject.GetComponent<MeshRenderer>().material = newMat;
            player.transform.parent = this.gameObject.transform;
            /*
            anim.SetBool("2", true);
            elevatorC.SetActive(false); 
            if(anim.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1)
            {
                player.transform.SetParent(null);

            }
            */

        }
        else
        {
            //this.gameObject.GetComponent<MeshRenderer>().material = mat; 
        }
    }


    void Transition()
    {
        Debug.Log("Cambio"); 
        player.transform.position = Calm_Teleport.transform.position;  
    }

    void ReturnTransition()
    {
        player.transform.position = FR_Teleport.transform.position;
        elevator.GetComponent<Elevator>().num = 2; 

    }

    
}
