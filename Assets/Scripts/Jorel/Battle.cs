using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Battle : MonoBehaviour
{
    public Character stats;
    public NavMeshAgent agent;
    public Transform npc;
    public LayerMask whatIsGround, whatIsEnemy;

    public float maxHealth;

    //Attacking
    public float timeBetweenAttack;
    public bool alreadyAttacked;
    
    //States
    public float sightRange, attackRange;
    public bool enemyInsightRange, enemyInAttackRange;

    // Start is called before the first frame update
    private void Awake()
    {
        //maxHealth = stats.GetComponent<maxHealth>();
       // npc = GameObject.Find("Character");
    }

    // Update is called once per frame
    void Update()
    {
        //check for sight and attack Range
        enemyInsightRange = Physics.CheckSphere(transform.position, sightRange, whatIsEnemy);
        enemyInAttackRange = Physics.CheckSphere(transform.position, attackRange, whatIsEnemy);

        if(!enemyInsightRange && !enemyInAttackRange)
        {
           
        }
    }

    private void Patroling()
    {

    }
    private void Chase()
    {
        agent.SetDestination(npc.position);
    }
    private void Attack()
    {
        agent.SetDestination(transform.position);
        transform.LookAt(npc);

        if (!alreadyAttacked)
        {
            // Attack code


            alreadyAttacked = true;
            Invoke(nameof(ResetAttack), timeBetweenAttack);
        }
    }
    private void ResetAttack()
    {
        alreadyAttacked = false;
    }
}
