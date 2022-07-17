using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fortress : MonoBehaviour
{
    public int maxHealth=500;
    public bool isDead=false;

    //UI
    public HealthBar healthbar;
    public GameObject healthUI;
    public int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    /*void Update()
    {
        if (!isDead)
        {
            //Spawn the Entity's

        }
    }*/

    public void SetDamage(int damage)
    {
        Debug.Log("Der Schaden an der Burg: " + damage);
        currentHealth -= damage;

        healthbar.SetHealth(currentHealth);

        if (currentHealth <= 0)
        {
            isDead = true;
            Destroy(gameObject);
            healthUI.SetActive(false);
            Destroy(healthUI);
        }
    }
}
