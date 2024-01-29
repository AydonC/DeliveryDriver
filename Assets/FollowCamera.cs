using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;

    //camera position must be the same as car position
    
    void LateUpdate()
    {
       transform.position = thingToFollow.transform.position + new Vector3 (0,0,-10); 
    }
}
