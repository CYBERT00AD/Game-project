using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem
{
    public float health;
    public float healthMax;
    // Start is called before the first frame update
    public HealthSystem(float StartHealth)
    {
        health = StartHealth;
        healthMax = StartHealth;
    }


    // Update is called once per frame
    

    public void ToDamage(float DamageAmount)
    {
        health -= DamageAmount;
    }

    public void ApplyHealth(float HealthAmount)
    {
        health += HealthAmount;

    }

    public float GetHealth()
    {
        return health;
    }

}
