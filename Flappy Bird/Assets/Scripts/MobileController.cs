using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobileController : MonoBehaviour
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


        
        
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            {

                rb.velocity = Vector3.up * jumpForce;
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
