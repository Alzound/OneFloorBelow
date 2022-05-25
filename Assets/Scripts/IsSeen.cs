using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsSeen : MonoBehaviour
{
    public GameObject[] aparitions; 
    public GhostSeen gS; 
    public bool seen = false; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GetComponent<Renderer>().isVisible)
        {
            gS.GhostDisappear(); 
            Debug.Log("ghost"); 
        }
    }
}
