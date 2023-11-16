using UnityEngine;


public class ColorMatchBahavior : MatchBehavior
{
    public ColorIDDataList colorIDDataListObj;

    private void Awake()
    {
        idObj = colorIDDataListObj.currentColor;
    }

    public void ChangeColor(SpriteRenderer render)
    {
        var newColor = idObj as ColorID;
        if (newColor != null) render.color = newColor.value;
    }
}
