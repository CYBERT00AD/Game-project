using UnityEngine;
using System.Collections;
 
 public class MouseAim : MonoBehaviour
{
    public Vector3 forward;
    void Update()
    {
        Vector3 dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        float angle = Mathf.Atan2(dir.x, dir.z) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, forward);
    }
}

