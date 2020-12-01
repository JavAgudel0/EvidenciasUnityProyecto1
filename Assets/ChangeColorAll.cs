using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColorAll : MonoBehaviour
{  
    public Renderer[] Mater;

    public Dropdown DropdownFaseNuevo;

    public Button BotonCerrar;

    //---------------------------------------------------

    void Start()
    {
        //NumeroFase = (la consulta de sql);
        Mater = GetComponentsInChildren<Renderer> ();
    }

    void Update()
    {
        
        CambiarPorDropdown();
        
    }

    private void OnMouseDown()
    {
        DropdownFaseNuevo.gameObject.SetActive(true);
        BotonCerrar.gameObject.SetActive(true);

        //CambiarColorChildrens();

    }

    void CambiarColorChildrens()
    {
        foreach (Renderer col in Mater)
        {
            col.material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        }
    }

    void CambiarPorDropdown()
    {
        switch (DropdownFaseNuevo.value)
        {
            
            case 1:
                foreach (Renderer col in Mater)
                {
                    col.material.SetColor("_Color", Color.red);
                }
                break;

            case 2:
                foreach (Renderer col in Mater)
                {
                    col.material.SetColor("_Color", Color.blue);
                }
                break;

            case 3:
                foreach (Renderer col in Mater)
                {
                    col.material.SetColor("_Color", Color.green);
                }
                break;

            case 4:
                foreach (Renderer col in Mater)
                {
                    col.material.SetColor("_Color", Color.yellow);
                }
                break;

        }
    }
}