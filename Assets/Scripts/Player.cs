using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private Rigidbody2D rb;
    public float velocidade;
    public AudioSource fly;
    public ParticleSystem dust;
    public GameObject gameOver;

    // Start is called before the first frame update
    void Start()
    {
       rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        
        Pular();

    }

    void Pular()
    {
        if(Input.GetButtonDown("Jump")){

            rb.velocity = Vector2.up * velocidade;
            fly.Play();
            dust.Play();
            
        }
        
    }
    
    void CreateDust()
    {
        dust.Play();
    }

    private void OnCollisionEnter2D(Collision2D other) {
        Time.timeScale = 0;
        gameOver.SetActive(true);
    }

}
