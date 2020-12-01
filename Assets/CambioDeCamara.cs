using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CambioDeCamara : MonoBehaviour
{
    public Camera CamaraTodo;
    public Camera CamaraParqueadero;
    public Camera CamaraRecepcion;
    public Camera CamaraTorres;
    public Camera CamaraTorre1Delante;
    public Camera CamaraTorre1Atras;
    public Camera CamaraTorre2;
    public Camera CamaraTorre3;
    public Dropdown DropdownCamarasPorSector;
    public Dropdown DropdownCamarasPorTorre;
    public Dropdown DropdownCamarasPorApartamento;


    public void MostrarTodo()
    {
        CamaraTodo.enabled = true;
        CamaraParqueadero.enabled = false;
        CamaraRecepcion.enabled = false;
        CamaraTorres.enabled = false;
    }

    public void MostrarParqueadero()
    {
        CamaraTodo.enabled = false;
        CamaraParqueadero.enabled = true;
        CamaraRecepcion.enabled = false;
        CamaraTorres.enabled = false;
    }

    public void MostrarRecepcion()
    {
        CamaraTodo.enabled = false;
        CamaraParqueadero.enabled = false;
        CamaraRecepcion.enabled = true;
        CamaraTorres.enabled = false;
    }

    public void MostrarTorres()
    {
        CamaraTodo.enabled = false;
        CamaraParqueadero.enabled = false;
        CamaraRecepcion.enabled = false;
        CamaraTorres.enabled = true;
    }

    public void ApagarCamaras()
    {
        object[] Cams = GameObject.FindObjectsOfType(typeof(Camera));
        foreach (Camera C in Cams)
        {
                C.enabled = false;
        }
    }

    public void PrenderCamaras()
    {
        object[] Cams = GameObject.FindObjectsOfType(typeof(Camera));
        foreach (Camera C in Cams)
        {
            C.enabled = true;
        }
    }


    void Start()
    {
        ApagarCamaras();
        CamaraTodo.enabled = true;
    }
    void Update()
    {
        switch (DropdownCamarasPorSector.value)
        {
            case 0:
                MostrarTodo();
                break;
            case 1:
                MostrarParqueadero();
                break;

            case 2:
                MostrarRecepcion();
                break;

            case 3:
                MostrarTorres();
                break;
        }

        switch (DropdownCamarasPorTorre.value)
        {
            case 1:
                ApagarCamaras();
                CamaraTorre1Delante.enabled = true;
                break;

            case 2:
                ApagarCamaras();
                CamaraTorre2.enabled = true;
                break;

            case 3:
                ApagarCamaras();
                CamaraTorre3.enabled = true;
                break;
        }

        if (DropdownCamarasPorApartamento.value == 1 || DropdownCamarasPorApartamento.value == 2)
        {
            ApagarCamaras();
            CamaraTorre1Atras.enabled = true;
        }
    }
}