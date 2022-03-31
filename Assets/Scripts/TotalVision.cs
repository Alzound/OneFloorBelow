using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotalVision : MonoBehaviour
{
    public float anglex, angley, anglez;
    public float angle; 
    public Camera cam;
    //public Vector3 midPointScreen = new Vector3(cam.fieldOfView,0,0);

    public RaycastHit hit = new RaycastHit();

    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        angle = Vector3.Angle((cam.transform.position), new Vector3(cam.fieldOfView,0,0));
        CheckForVision();
        Debug.Log(angle); 
    }

    void CheckForVision()
    {
        if(angle <= 45)
        {
            cam.cullingMask = LayerMask.GetMask("Default", "TransparentFX", "Hidden");         
        }
        if(angle > 45 || angle <= 175)
        {
            cam.cullingMask = LayerMask.GetMask("Default", "Transparent"); 
        }
        if(angle >= 180)
        {
            cam.cullingMask = LayerMask.GetMask("Default", "TransparentFX", "Hidden"); 
        }
    }
}
