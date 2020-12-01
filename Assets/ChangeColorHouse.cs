using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColorHouse : MonoBehaviour
{
    public Renderer[] ObjCasa;

    public Dropdown DropdownFaseNuevo;

    public Button BotonCerrar;



    // Start is called before the first frame update
    void Start()
    {
        ObjCasa = GetComponentsInChildren<Renderer>();
    }

    // Update is called once per frame
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

    void CambiarPorDropdown()
    {
        switch (DropdownFaseNuevo.value)
        {

            case 1:
                foreach (Renderer col in ObjCasa)
                {
                    col.material.SetColor("_Color", Color.red);
                }
                break;

            case 2:
                foreach (Renderer col in ObjCasa)
                {
                    col.material.SetColor("_Color", Color.blue);
                }
                break;

            case 3:
                foreach (Renderer col in ObjCasa)
                {
                    col.material.SetColor("_Color", Color.green);
                }
                break;

            case 4:
                foreach (Renderer col in ObjCasa)
                {
                    col.material.SetColor("_Color", Color.yellow);
                }
                break;

        }
    }
}
