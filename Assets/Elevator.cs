using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events; 
using UnityEngine.EventSystems; 

public class Elevator : MonoBehaviour
{
    public bool first; 
    bool f_check; 
    public bool second;
    bool s_check;     
    public bool third;
    bool t_check;

    GameObject elevator;
    public GameObject player; 
    public GameObject trigger;  

    public Animator anim;   

    public Material mat, newMat;  

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(trigger == true)
        {
            player.transform.position = elevator.transform.position;
        }
         
    }

    void CheckRay()
    {
        if(first == true)
        {
            this.gameObject.GetComponent<MeshRenderer>().material = newMat;
            //Aplica un sonido después de error.

        }
        else
        {
            this.gameObject.GetComponent<MeshRenderer>().material = mat; 
        }
        if(second == true)
        {
            this.gameObject.GetComponent<MeshRenderer>().material = newMat;
            anim.SetBool("2", true);
        }
        else
        {
            this.gameObject.GetComponent<MeshRenderer>().material = mat; 
        }
        if(third == true)
        {
            this.gameObject.GetComponent<MeshRenderer>().material = newMat;
            anim.SetBool("3", true);
        }
        else
        {

        }
    }
}
