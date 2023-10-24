using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Float Data", menuName = "Float Data")]
public class FloatData : ScriptableObject
{
    [SerializeField] public float value;

    public float Value
    {
        get { return value; }
        set { this.value = value; }
    }

    public void UpdateValue(float num)
    {
        value += num;
    }
}
