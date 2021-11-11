using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    private float r, g, b;
    private float firstScale;
    private float timer;
    private int counter;
    void Start()
    {
        transform.position = new Vector3(6, 8, -1);
        timer = 1.0f;
        counter = 0;
    }
    
    void Update()
    {
        timer -= Time.deltaTime;
        
        if (timer <= 0)
        {
            counter = Random.Range(0, 3);Debug.Log(counter);
            
            ColorChange();
            //Random Scale
            firstScale = 0.2f;
            transform.localScale = Vector3.one * firstScale;
            //Reset value of timer and counter
            timer = 2.0f;
        }
        if (counter == 0)
        {
            transform.Rotate(20.0f * Time.deltaTime * 5, 0, 0);
        }
        else if (counter == 1)
        {
            transform.Rotate(0, 20.0f * Time.deltaTime * 5, 0);
        }
        else if (counter == 2)
        {
            transform.Rotate(0, 0, 20.0f * Time.deltaTime * 5);
        }
        transform.localScale = transform.localScale +
            new Vector3(0.8f*Time.deltaTime, 0.8f * Time.deltaTime, 0.8f * Time.deltaTime);
    }
    void ColorChange()
    {
        //changing colors of the cube
        r = Random.Range(0.0f, 1.0f);
        g = Random.Range(0.0f, 1.0f);
        b = Random.Range(0.0f, 1.0f);
        Material material = Renderer.material;
        material.color = new Color(r, g, b, 1.0f);
    }

}
