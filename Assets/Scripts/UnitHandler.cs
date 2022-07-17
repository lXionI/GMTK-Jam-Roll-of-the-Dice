using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitHandler : MonoBehaviour
{
    [SerializeField]
    private UnitSO unitMeta;
    private int _attack;
    private int _health;
    private string _name;
    private int _attackRange;
    private bool canMove = true;
    // Start is called before the first frame update
    void Start()
    {
        setUpStats();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void setUpStats()
    {
        _attack = unitMeta.unitAttack;
        _health = unitMeta.unitHealth;
        _name = unitMeta.unitName;
        _attackRange = unitMeta.unitRange;
    }

    public void moveUnit()
    {
        canMove = false;
    }

    public void newTurn()
    {
        canMove = true;
    }
}
