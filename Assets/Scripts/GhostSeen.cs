using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostSeen : MonoBehaviour
{
    //public IsSeen isSeen;
    public GameObject camOther; 

    // Start is called before the first frame update
    private void Update() {

        GhostRaycast(); 
    }

    

    public IEnumerator GhostDisappear()
    {
        //available = true; 
        yield return new WaitForSeconds(3);
        this.gameObject.SetActive(false);
        yield return new WaitForSeconds(1); 
        //available = false; 
        Debug.Log("salir"); 
    }

    public void GhostRaycast()
    {
        RaycastHit hit; 
        Physics.Raycast(camOther.transform.position, Vector3.forward, out hit ,1250, 6,QueryTriggerInteraction.Collide);
        if(hit.transform.CompareTag("Ghost0"))
        {
            hit.transform.gameObject.SetActive(false);
            Debug.Log("cazando f"); 
        }
        Debug.DrawRay(camOther.transform.position, Vector3.left * 10, Color.red);
    }

}
