using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsSeen : MonoBehaviour
{
    public GameObject[] aparitions; 
    Renderer cam; 

    // Start is called before the first frame update
    void Start()
    {
        cam = this.gameObject.GetComponent<Renderer>(); 
        aparitions = new GameObject[15];  

        if(cam.isVisible && gameObject.CompareTag("Hidden"))
        {
            gameObject.SetActive(false); 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
