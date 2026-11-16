using NUnit.Framework;
using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    public GameObject Ball;
    Vector2 SpawnPoint;
    public bool Player1;

    void Start()
    {

    }

    void Update()
    {
        SpawnPoint = transform.position;
        if (!GameManagerr.Instance.HasShot)
        {
            if (GameManagerr.Instance.IsPlayer1 && Player1)
            {
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    Instantiate(Ball, SpawnPoint, quaternion.identity);
                }
            }

            if (!GameManagerr.Instance.IsPlayer1 && !Player1)
            {
                if (Input.GetKeyDown(KeyCode.RightShift))
                {
                    Instantiate(Ball, SpawnPoint, quaternion.identity);
                }
            }
        }

    }
}
