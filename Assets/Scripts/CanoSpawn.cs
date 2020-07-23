using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanoSpawn : MonoBehaviour
{

    public GameObject cano;
    public float altura;
    public float intervalo;
    public float timer;

    // Start is called before the first frame update
    void Start()
    {
        Spawn();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer > intervalo)
        {
            Spawn();
            timer = 0;
        }
        timer += Time.deltaTime;
    }

    void Spawn()
    {
        GameObject novoCano = Instantiate(cano);
        novoCano.transform.position = transform.position;
        novoCano.transform.position = new Vector3(transform.position.x, Random.Range(-altura, altura));
        Destroy(novoCano, 5f);
    }

}
