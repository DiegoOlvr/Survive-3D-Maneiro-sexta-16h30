using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // START => SEMPRE ACONTECE NO INICIO DO SCRIPT
    void Start()
    {
        
    }

    // UPDATE => REPETE COM O CLOCK DO SEU PROCESSADOR
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ilha"))
        {
            // INIMIGO MORRA QUANDO ENCOSTAR NO CHÃO
            Destroy(gameObject);
        }
    }
}
