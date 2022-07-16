using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerSO", menuName = "Player/PlayerSO")]
public class PlayerSO : ScriptableObject
{
    public int numberNations;
    public int unitsPetTurn;
    // Placeholder for possible units to generate
    public List<UnitSO> units;
}
