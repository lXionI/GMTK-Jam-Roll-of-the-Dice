using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitHandler : MonoBehaviour
{
    [SerializeField]
    private UnitSO unitMeta;
    private bool canMove = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
