using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Square : MonoBehaviour
{
    public Color startColor;
    private Renderer renderer;

    void Start()
    {
        print("bla bla");
        renderer = GetComponent<Renderer>();
        startColor = renderer.material.color;
    }

    void OnMouseEnter()
    {
        print("bla2");
        renderer.material.color = Color.red;
        
    }
    void OnMouseExit()
    {
        renderer.material.color = Color.white; 
    }

    void Update()
    {
        
        
    }
}
