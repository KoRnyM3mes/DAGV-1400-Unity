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
        render.color = newColor.value;
    }

    public void TestChangeColor(SpriteRenderer renderer)
    {
        renderer.color = Color.red;
    }
}
