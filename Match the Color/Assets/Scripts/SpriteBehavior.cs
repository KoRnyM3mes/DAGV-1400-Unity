using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class SpriteBehavior : MonoBehaviour
{
    private SpriteRenderer rendererObj;
    void Start()
    {
        rendererObj = GetComponent<SpriteRenderer>();
    }

}
