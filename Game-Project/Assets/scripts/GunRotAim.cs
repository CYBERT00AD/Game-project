using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunRotAim : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gunObj;
    public float smoothRotation;


    // Update is called once per frame

    void Update()
    {
        Plane PlayerPlane = new Plane(Vector3.up, transform.position);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float hitDist = 0.0f;
        if (PlayerPlane.Raycast(ray, out hitDist))
        {
            Vector3 targetPoint = ray.GetPoint(hitDist);
            Quaternion targetRotation = Quaternion.LookRotation(targetPoint - transform.position);
            targetRotation.x = 0;
            targetRotation.z = 0;
            //Quaternion resultRotation = Quaternion.Slerp(transform.rotation, targetRotation, smoothRotation * Time.deltaTime);
            gunObj.transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, smoothRotation * Time.deltaTime);
            //gunObj.transform.rotation = Quaternion(0,1,0,1);
        }        
    }
}
