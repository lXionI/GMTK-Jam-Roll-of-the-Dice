using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="BaseSetupConfig", menuName="Player/BaseSetup")]
public class BaseSetupSO : ScriptableObject
{
    public GameObject playerRef;
    public GameObject baseRef;
    public int unitsPerRoundStart = 3;
}
