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

    public Animator anim;   

    public Material mat;
    public Material newMat;  

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CheckRay()
    {
        if(first == true)
        {
            this.gameObject.GetComponent<MeshRenderer>().material = newMat;
            if(f_check == false)
            {

            } 
        }
        else
        {
            this.gameObject.GetComponent<MeshRenderer>().material = mat; 
        }
        if(second == true)
        {

        }
        else
        {

        }
        if(third == true)
        {

        }
        else
        {

        }
    }
}
