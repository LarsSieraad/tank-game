using NUnit.Framework;
using UnityEditor.Callbacks;
using UnityEngine;

public class PlayerMovement1 : MonoBehaviour
{
    Rigidbody2D RB;
    public float speed = 5f;
    public bool Player1;
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (GameManagerr.Instance.IsPlayer1 && Player1)
        {
            if (Input.GetKey(KeyCode.D))
            {
                RB.AddForce(new Vector2(speed * Time.deltaTime, 0), ForceMode2D.Impulse);
            }
            if (Input.GetKey(KeyCode.A))
            {
                RB.AddForce(new Vector2(-speed * Time.deltaTime, 0), ForceMode2D.Impulse);
            }
        }

        if (!GameManagerr.Instance.IsPlayer1 && !Player1)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                RB.AddForce(new Vector2(speed * Time.deltaTime, 0), ForceMode2D.Impulse);
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                RB.AddForce(new Vector2(-speed * Time.deltaTime, 0), ForceMode2D.Impulse);
            }
        }
    }
}
