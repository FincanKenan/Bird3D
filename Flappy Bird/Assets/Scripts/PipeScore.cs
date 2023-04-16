using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScore : MonoBehaviour
{
    private bool scored = false;

   
   
    void OnTriggerEnter(Collider other)
    {
        if (!scored && other.gameObject.CompareTag("Bird"))
        {
            scored = true;
            Manager manager = FindObjectOfType<Manager>();
            manager.IncreaseScore();
        }
    }



    
}

