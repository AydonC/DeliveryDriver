using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSpeedUp : MonoBehaviour
{
    [SerializeField] int rotateSpeeding = 35; 
 
    void Update()
    {
        transform.Rotate(0,0,rotateSpeeding);
        
    }
}
