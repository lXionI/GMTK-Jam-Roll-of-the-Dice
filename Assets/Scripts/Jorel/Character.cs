using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private int baseHealth=6;
    public int maxHealth;
    public int currentHealth;
    public int unitCount;
    //public int damage;
    //Roll for damage
    //private int dice=0;
    public bool isDead = false;
    //tag um um das Tag der Jeweiligen Fraktion zu ändern
    public string trigger; 

    public float attackSpeed;
    public float attackRange;

    /*public Character( int unitCount)
    {
        this.unitCount = unitCount;
        maxHealth = baseHealth * unitCount;
        currenthealth = maxHealth;
    }*/

    public void Start()
    {
        maxHealth = baseHealth * unitCount;
        currentHealth = maxHealth;
    }

    public void Update()
    {
        int damage = RollDamage();
        RaycastHit hit;
        Ray ray = new Ray(transform.position,transform.TransformDirection(Vector3.forward));
        if (!isDead)
        {
            if (Physics.SphereCast(ray,attackRange, out hit, attackRange))
            {
                //Debug.Log("ich erkenne Etwas");
                if (hit.collider.tag == trigger)
                {
                   // Debug.Log("Treffe auf den Feind");
                    hit.collider.GetComponent<Character>().Attack(damage);//.SetDamage(damage); //(RollDamage());
                    //Debug.Log("Der schaden ist: " + damage);
                }
            }
        }
    }
    public void SetDamage(int damage)
    {
       // Debug.Log("Der abgezogene Schaden ist: " + damage);
        currentHealth -= damage;
        //isDamaged = true;

        //healthbar.SetHealth(currentHealth);
        //m.SetColor("_BaseColor", Color.red);

        if (currentHealth <= 0)
        {
            isDead = true;
            Destroy(gameObject);
            //healthUI.SetActive(false);
            //Destroy(healthUI);
        }
    }
    public void Attack( int damage)
    {
        Debug.Log("Attack Schaden : " + damage);
        // Play Attack animation

            SetDamage(damage);
            new WaitForSeconds(attackSpeed);
    }

    /** change Form ,if characterCount greater than 
     * unitCount<=4 == D4
     * unitCount<=6 && >4 == D6
     * unitCount<=8 && >6 == D8
     * unitCount<=12 && >8 == D12
     * unitCount<=20 && >12 == D20
    */


    public int RollDamage()
    {
        int dots = 0; 
        if (unitCount <= 4)
        {
            dots = 4;
        }
        else if(unitCount <=6)
        {
            dots = 6; 
        }
        else if (unitCount <= 8)
        {
            dots = 8;
        }
        else if (unitCount >= 12)
        {
            dots = 12;
        }
        else if (unitCount >= 20)
        {
            dots = 20;
        }
        int dice = Random.Range(1, dots+1);
        
        return dice;
    }

}
