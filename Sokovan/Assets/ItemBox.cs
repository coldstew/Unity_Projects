using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    public bool isOverlaped = false;
    private Renderer myRenderer;

    public Color touchColor;
    private Color originalColor;
    // Start is called before the first frame update
    void Start()
    {
        myRenderer = GetComponent<Renderer>();
        originalColor = myRenderer.material.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "ClearPoint")
        {
            isOverlaped = true;
            myRenderer.material.color = touchColor;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if(other.tag == "ClearPoint")
        {
            isOverlaped = false;
            myRenderer.material.color = originalColor;
        }
    }

    void OnTriggerStay(Collider other)
    {
        if(other.tag == "ClearPoint")
        {
            isOverlaped = true;
            myRenderer.material.color = touchColor;
        }
    }
}
