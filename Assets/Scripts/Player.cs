
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Transform ct;
    public int velocidade = 30;
    public float force = 30f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        Debug.Log(horizontal);

        
        if (GetComponent<Rigidbody>().velocity.magnitude <= velocidade)
        {
            GetComponent<Rigidbody>().AddForce(horizontal * force, 0, 0);

        }
        
    }
}
