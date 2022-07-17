using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitList : MonoBehaviour
{
    public PlayerSO _playerInfo;
    public List<GameObject> units;

    void Start()
    {
    }

    public GameObject getRandomUnit()
    {
        return units[Random.Range(0, units.Count)];
    }
}
