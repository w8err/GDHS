using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class StageData : ScriptableObject
{
    // 컴포넌트에서 설정
    [SerializeField] private Vector2 min;
    [SerializeField] private Vector2 max;

    public Vector2 LimitMin => min;
    public Vector2 LimitMax => max;
}