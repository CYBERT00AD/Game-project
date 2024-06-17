using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 Offset;
    public float Smooth;

    private Vector3 velocity = Vector3.zero;


    // Start is called before the first frame update
    void Update()
    {
        Vector3 pos = new Vector3();
        pos.x = player.position.x + Offset.x;
        pos.y = player.position.y + Offset.y;
        pos.z = player.position.z + Offset.z;
        //transform.position = player.position + Offset;
        transform.position = Vector3.SmoothDamp(transform.position, pos, ref velocity, Smooth);
    }

}
