using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wearpon : MonoBehaviour
{
    public float Firerate = 0;
    public float Damage = 0;
    public LayerMask notToHit;

    float TimeToFire = 0;
    Transform FirePoint;

    private void Awake()
    {
        FirePoint = transform.Find("FirePoint");
        if (FirePoint == null)
        {

            Debug.Log("No FirePoint?! What?");
        }
    }
    private void Update()
    {
        if (Firerate == 0)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Shot();
            }
        }
        else
        {
            if (Input.GetButtonDown("Fire1") && (Time.time > TimeToFire))
            {
                TimeToFire = Time.time * 1 / Firerate;
                Shot();
            }
        }
    }
    void Shot()
    {
        //Vector2 MousePosition = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
        //Vector2 FirePointPosition = new Vector2(FirePoint.position.x, FirePointPosition.position.y);
        //RaycastHit2D hit = Physics2D.Raycast(FirePointPosition, MousePosition - FirePointPosition, 100, notToHit);
        //Debug.DrawLine(FirePointPosition, MousePosition - FirePointPosition, Color.cyan);
        //if (hit.collider != null)
        //{
        //    Debug.DrawLine(FirePointPosition, hit.point, Color.red);
        //    Debug.Log("We hit " + hit.collider.name + " dealting " + Damage + " damage.");
        //}
    }

}
