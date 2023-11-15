using UnityEngine;

public class ColorIDBehavior : IdContainerBehavior
{
    public ColorIDDataList ColorIDDataListobj;

    private void Awake()
    {
        idObj = ColorIDDataListobj.currentColor;
    }
}
