using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float Amplitude;
    private Vector3 InitialP;
    public float speed;
    void Start()
    {
        InitialP = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position = new Vector3(InitialP.x+Amplitude*Mathf.Sin(Time.time*speed)*6.28f, InitialP.y, InitialP.z);
    }
}
