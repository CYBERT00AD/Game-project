using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject PlayerObj;
    private Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
        transform.position = PlayerObj.transform.position + transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //GameObject[] targets = GameObject.FindGameObjectsWithTag("Target");
        //GameObject Target = targets[0];
        transform.position = PlayerObj.transform.position + pos;
        transform.LookAt(PlayerObj.transform.position);
        //transform.LookAt(Target.transform.position);

    }
}
