using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "UnitParametersSO", menuName = "Unit/ParametersSO")]
public class UnitParametersSO : ScriptableObject
{
    public int health = 0;
    public int range = 0;
    public int moveSpeed = 0;
}
