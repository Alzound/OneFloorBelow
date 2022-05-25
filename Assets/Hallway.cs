using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hallway : MonoBehaviour
{
    public Transform positionT; 
    public int num = 0; 
    // Start is called before the first frame update

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Hall"); 
            other.gameObject.transform.position = positionT.position; 
            num++;
            if(num == 10)
            {

            }
        }
    }
}
