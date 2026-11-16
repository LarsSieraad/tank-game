using NUnit.Framework;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class FireScript : MonoBehaviour
{
    Rigidbody2D RB;
    GameObject gunBarrel1;
    GameObject gunBarrel2;
    public GameObject expolosion;
    public AudioSource audioSource;
    public AudioClip hit;
    public AudioClip fire;
    public GameObject explode;
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
        gunBarrel1 = GameObject.Find("cannon1");
        gunBarrel2 = GameObject.Find("cannon2");

        

        if (!GameManagerr.Instance.HasShot)
        {
            if (GameManagerr.Instance.IsPlayer1)
            {
                RB.AddForce(gunBarrel1.transform.up * 10, ForceMode2D.Impulse);
                GameManagerr.Instance.HasShot = true;
                AudioSource.PlayClipAtPoint(fire, transform.position);
            } 
            
            else if (!GameManagerr.Instance.IsPlayer1)
            {
                RB.AddForce(gunBarrel2.transform.up * 10, ForceMode2D.Impulse);
                GameManagerr.Instance.HasShot = true;
                AudioSource.PlayClipAtPoint(fire, transform.position);
            }
        }
            
        
        
    }

    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("player1"))
        {
            GameManagerr.Instance.damage(25, true);
        }
        if (collision.gameObject.CompareTag("player2"))
        {
            GameManagerr.Instance.damage(25, false);
        }
        AudioSource.PlayClipAtPoint(hit, transform.position);
        Instantiate(explode, transform.position, quaternion.identity);
        Destroy(gameObject);
    }
}
