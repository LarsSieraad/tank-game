using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerr : MonoBehaviour
{
    public bool IsPlayerHit = false;
    public int score1;
    public int health1 = 100;
    public int score2;
    public int health2 = 100;
    public bool IsPlayer1 = true;
    public bool HasShot = false;
    public static GameManagerr Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        SceneManager.LoadScene("MainMenu");
    }

    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("hit space");

            HasShot = false;

            if (IsPlayer1)
            {
                Debug.Log("player one is false now");
                IsPlayer1 = false;
            }

            else if (!IsPlayer1)
            {
                Debug.Log("player one is true now");
                IsPlayer1 = true;
            }
        }

        if (health1 <= 0)
        {
            score2++;
            health1 = 100;
        }

        if (health2 <= 0)
        {
            score1++;
            health2 = 100;
        }
    }

    public void damage(int damage,bool DamagePlayer1)
    {
        if (DamagePlayer1)
        {
            health1 -= damage;
        }
        if (!DamagePlayer1)
        {
            health2 -= damage;
        }
    }
}
