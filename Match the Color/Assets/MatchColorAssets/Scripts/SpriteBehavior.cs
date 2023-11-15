using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class SpriteBehavior : MonoBehaviour
{
    private SpriteRenderer rendererObj;
    void Awake()
    {
        rendererObj = GetComponent<SpriteRenderer>();
    }

    public void ChangeRenderColor(ColorID obj)
    {
        rendererObj.color = obj.value;
    }

    public void ChangeRendererColor(ColorIDDataList obj)
    {
        rendererObj.color = obj.currentColor.value;
    }
}
