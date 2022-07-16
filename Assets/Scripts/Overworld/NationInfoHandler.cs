using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NationInfoHandler : MonoBehaviour
{
    public NationSO nationMeta;
    [SerializeField]
    private GameObject owner;
    [SerializeField]
    private List<GameObject> unitsInNation;
    public bool canAttack;

    void Start()
    {
        if(owner != null) GetComponent<MeshRenderer>().material = owner.GetComponent<MeshRenderer>().material;
    }

    public GameObject getOwner()
    {
        return owner;
    }

    public void setOwner(GameObject newOwner)
    {
        owner = newOwner;
        GetComponent<MeshRenderer>().material = owner.GetComponent<MeshRenderer>().material;
    }

    public void nationAttacked()
    {
        canAttack = false;
    }

    public void addUnits(GameObject unit)
    {
        unitsInNation.Add(unit);
    }

    // Debug function for now
    public void removeUnits(int amount)
    {
        if(amount > unitsInNation.Count) amount = unitsInNation.Count;
        unitsInNation.RemoveRange(0, amount);
    }

    public void removeAllUnits()
    {
        unitsInNation.RemoveRange(0, unitsInNation.Count);
    }

    public List<GameObject> getUnits()
    {
        return unitsInNation;
    } 
}
