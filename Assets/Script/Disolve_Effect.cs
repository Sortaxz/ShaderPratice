using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disolve_Effect : MonoBehaviour
{
    Material material;
    private bool isDisolving = false;
    private float fade =1f;

    private void Awake() 
    {
        material = GetComponent<SpriteRenderer>().material;    
    }

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            isDisolving = true;
        }

        if(isDisolving)
        {
            fade -= Time.deltaTime;
        }

        if(fade <= 0f)
        {
            fade = 0f;
            isDisolving = false;
        }

        material.SetFloat("_Fade",fade);
    }
}
