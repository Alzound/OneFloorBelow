using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowDetector : MonoBehaviour
{
    public float Appearangle = 50;
    Shadow[] shadows;
    void Start()
    {
        shadows = GameObject.FindObjectsOfType<Shadow>();
    }

    void Update()
    {
        bool visible = false;
        float angle = 0;
        for (int i = 0; i < shadows.Length; i++)
        {
                visible = true;
                angle = 
                Vector3.Angle
                (transform.forward,
                (shadows[i].transform.position - transform.position));

            RaycastHit hit;
            if (Physics.Linecast(shadows[i].transform.position, transform.position, out hit))
            {
                visible = false;
            }
            if (angle > Appearangle)
            {
                if (visible)
                {
                    shadows[i].Dissapear();
                }
            }
        }
    }
}