using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitList : MonoBehaviour
{
    public List<GameObject> units;

    public GameObject getRandomUnit()
    {
        return units[Random.Range(0, units.Count)];
    }

    void Update()
    {
        Debug.Log(getRandomUnit());
    }
}
