
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform ct;
    public int velocidade = 30;
    public float force = 30f;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");

        
        if (rb.velocity.magnitude <= velocidade)
        {
            rb.AddForce(horizontal * force, 0, 0);

        }
        
    }

    private void OnCollisionEnter(Collision colidido)
    {
        if (colidido.gameObject.CompareTag("Inimigo"))
        {
            Destroy(gameObject);
        }
    }
}
