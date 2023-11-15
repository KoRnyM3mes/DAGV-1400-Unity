using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ColorIDDataList : ScriptableObject
{
    public List<ColorID> colorIDList;

    public ColorID currentColor;

    private int num;

    public void SetColorRandomly(ColorIDDataList obj)
    {
        num = Random.Range(0, obj.colorIDList.Count);
        currentColor = colorIDList[num];
    }
}
