using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundScroll : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    private float animSpeed = 0.5f;
    
    void Awake()
    {
        meshRenderer = FindObjectOfType<MeshRenderer>();
    }

    
    void Update()
    {
        meshRenderer.material.mainTextureOffset += new Vector2(animSpeed * Time.deltaTime, 0);
    }
}
