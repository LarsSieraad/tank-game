using UnityEngine;

public class ground : MonoBehaviour
{
    Sprite sprite;
    PolygonCollider2D pc2d;
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>().sprite;
        pc2d = GetComponent<PolygonCollider2D>();
    }

    void Update()
    {
        
    }
}
