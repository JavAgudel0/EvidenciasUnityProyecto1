using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickToDestroy : MonoBehaviour
{
    public Renderer colorObjeto;

    private void Start()
    {
        colorObjeto = GetComponent<Renderer>();
        colorObjeto.material.SetColor("_Color", Color.white);
        
    }

    void OnMouseDown()
    {
        colorObjeto.material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        
    }
}
