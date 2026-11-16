using UnityEditor.UI;
using UnityEngine;

public class can : MonoBehaviour
{
    public float speed = 2;
    public bool Player1;
    void Start()
    {

    }

    void Update()
    {
        if (GameManagerr.Instance.IsPlayer1 && Player1)
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.Rotate(new Vector3(0, 0, speed * Time.deltaTime));
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.Rotate(new Vector3(0, 0, -speed * Time.deltaTime));
            }
        }

        if (!GameManagerr.Instance.IsPlayer1 && !Player1)
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.Rotate(new Vector3(0, 0, speed * Time.deltaTime));
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Rotate(new Vector3(0, 0, -speed * Time.deltaTime));
            }
        }
    }

}
