using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum NationType
{
    DEFAULT = 0,
    BASE = 1,
    FACTORY = 2,
}


[CreateAssetMenu(fileName = "NationSO", menuName = "Nation/NationSO")]
public class NationSO : ScriptableObject
{
    public int occupationID;
    public string battleSceneName;
    public NationType type;
    // Placeholder for unit
    public List<UnitSO> unitToProduce;
}
