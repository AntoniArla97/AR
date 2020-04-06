using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalPlacementScript : MonoBehaviour
{


    void Update()
    {
        RaycastHit hit;
        
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            
        }
        else
        {
            
        }
    }
}
