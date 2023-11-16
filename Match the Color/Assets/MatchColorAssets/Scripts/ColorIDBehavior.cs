using UnityEngine;

public class ColorIDBehavior : IdContainerBehavior
{
    public ColorIDDataList colorIDDataListObj;

    private void Awake()
    {
        if (colorIDDataListObj != null) idObj = colorIDDataListObj.currentColor;
    }
}
