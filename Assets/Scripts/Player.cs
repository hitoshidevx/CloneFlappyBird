using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    private Rigidbody2D rb;
    public float velocidade;
    public AudioSource fly;

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

        }
        
    }
}
