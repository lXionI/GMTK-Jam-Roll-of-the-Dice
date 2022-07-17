using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerSO", menuName = "Player/PlayerSO")]
public class PlayerSO : ScriptableObject
{
    public GameObject _startNation;
    public GameObject _playerPrefab;
    // public int _numberNations;
    public int _unitsPetTurn;
    // Placeholder for possible units to generate
    public List<UnitSO> _units;
}
