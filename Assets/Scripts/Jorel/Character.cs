using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private int baseHealth=6;
    public int maxHealth;
    private int currenthealth;
    public int unitCount;
    //public int damage;
    //Roll for damage
    public int dice=0;
    public bool isDead = false;
    //tag um um das Tag der Jeweiligen Fraktion zu ändern
    public string tag; 

    public float attackSpeed;
    public float attackTime;
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
        currenthealth = maxHealth;
    }

    public void Update()
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position,Vector3.forward);
        if (!isDead)
        {
            if (Physics.Raycast(ray, out hit, attackRange))
            {
                if (hit.collider.tag == tag)
                {
                    Attack();
                }
            }
        }
    }

    public void Attack()
    {

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
        int dice = Random.Range(1, dots);
        
        return dice;
    }

}
