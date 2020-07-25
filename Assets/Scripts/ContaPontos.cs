using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContaPontos : MonoBehaviour
{

    private GameObject pontuacao;
    private AudioSource audioPonto;
    public int pontos = 0;

    // Start is called before the first frame update
    void Start()
    {
        pontuacao = GameObject.Find("TxTPontos");
        audioPonto = GameObject.Find("AudioPontos").GetComponent<AudioSource>();

    }

    private void OnTriggerEnter2D(Collider2D other) {

        pontos = Int32.Parse(pontuacao.GetComponent<Text>().text);
        pontos++;
        pontuacao.GetComponent<Text>().text = pontos.ToString();


    }

}
