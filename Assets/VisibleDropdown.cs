using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VisibleDropdown : MonoBehaviour
{
    public Dropdown DropdownSector;
    public Dropdown DropdownTorres;
    public Dropdown DropdownPiso;
    public Dropdown DropdownApartamentos;
    public Dropdown DropdownFasesNuevo;
    public Button BotonCerrar;

    //------------------ Ocultar -----------------------------------
    public void OcultarDropdownsSector()
    {
        DropdownTorres.gameObject.SetActive(false);
        DropdownTorres.value = 0;

        DropdownPiso.gameObject.SetActive(false);
        DropdownPiso.value = 0;

        DropdownApartamentos.gameObject.SetActive(false);
        DropdownApartamentos.value = 0;

        DropdownFasesNuevo.gameObject.SetActive(false);
        DropdownFasesNuevo.value = 0;

        BotonCerrar.gameObject.SetActive(false);
    }

    public void OcultarDropdownsTorre()
    {
        DropdownPiso.gameObject.SetActive(false);
        DropdownPiso.value = 0;

        DropdownApartamentos.gameObject.SetActive(false);
        DropdownApartamentos.value = 0;
    }

    public void OcultarDropdownsPiso()
    {
        DropdownApartamentos.gameObject.SetActive(false);
        DropdownApartamentos.value = 0;
    }

    public void OcultarDropdownsApartamento()
    {
    }

    //----------------------Mostrar----------------------------------
    public void MostrarTorres()
    {
        DropdownTorres.gameObject.SetActive(true);

       
    }

    public void MostrarPisos()
    {
        DropdownPiso.gameObject.SetActive(true);

        
    }

    public void MostrarApartamentos()
    {
        DropdownApartamentos.gameObject.SetActive(true);

       
    }

    public void MostrarFase()
    {
    }
//---------------------------------------------------------

    void Update()
    {
        if (DropdownSector.value == 0 || DropdownSector.value == 1 || DropdownSector.value == 2)
        {
            OcultarDropdownsSector();
        }

        else
        {
            MostrarTorres();

            if (DropdownTorres.value == 0)
            {
                OcultarDropdownsTorre();
            }
            else
            {
                MostrarPisos();

                if (DropdownPiso.value == 0)
                {
                    OcultarDropdownsPiso();
                }
                else
                {
                    MostrarApartamentos();

                    if (DropdownApartamentos.value == 0)
                    {
                        OcultarDropdownsApartamento();
                    }
                    else
                    {
                        MostrarFase();
                    }
                }
            }   
        }
    }
}