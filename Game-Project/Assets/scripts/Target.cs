using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public HealthSystem health;
    // Start is called before the first frame update
    void Start()
    {
         health = new HealthSystem(100); 
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q)) 
        {
            health.ToDamage(5);
            Debug.Log(health.GetHealth());
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            health.ApplyHealth(10);
            Debug.Log(health.GetHealth());
        }

        if(health.GetHealth() <= 0) 
        {
            Destroy(gameObject);
        }
    }

    void ToDamage(float amount)
    {
        health.ToDamage(amount);
    }
}
