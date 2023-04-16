using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controll : MonoBehaviour
{
    private Rigidbody rb;
    public float jumpForce;

    public Manager manager;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        manager = FindObjectOfType<Manager>();
    }

    
    void Update()
    {
        if (transform.position.y > 7.60f)
        {
            manager.GameOver();
        }
         
        

        if (Input.GetKeyDown(KeyCode.Space))
        {
            
             rb.velocity = Vector3.up*jumpForce;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("wall"))
        {
            manager.GameOver();
        }
    }
}
