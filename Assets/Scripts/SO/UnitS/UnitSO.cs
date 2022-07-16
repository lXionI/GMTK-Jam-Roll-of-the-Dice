using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="UnitSO", menuName="Unit/UnitSO")]
public class UnitSO : ScriptableObject
{
    public string unitName = "DefaultUnit";             
    public int unitHealth = 1;
    public int unitAttack = 1;
    public int unitRange = 3;                       // Attack Range
    public int unitMovement = 1;                    // Movement in Battle
    public int unitOverworldMovement = 1;           // Movement in Overworld
}
