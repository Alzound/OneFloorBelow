using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour
{
    public Animator anim; 
    // Start is called before the first frame update
    void Start()
    {
        anim.SetBool("credits", true);
    }

    
}
