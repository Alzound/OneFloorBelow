using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsSeen : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        if(gameObject.GetComponent<Renderer>().isVisible && gameObject.CompareTag("Hidden"))
        {
         gameObject.SetActive(false); 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
