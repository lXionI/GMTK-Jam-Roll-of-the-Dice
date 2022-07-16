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

    public void nationAttacked()
    {
        canAttack = false;
    }

    public void addUnits(GameObject unit)
    {
        unitsInNation.Add(unit);
    }

    public List<GameObject> getUnits()
    {
        return unitsInNation;
    } 
}
