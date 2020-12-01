using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cerrar : MonoBehaviour
{
    public Button Boton;

    public Dropdown Seleccion;


    private void Start()
    {
        Button btn = Boton.GetComponent<Button>(); //Grabs the button component
        btn.onClick.AddListener(TaskOnClick); //Adds a listner on the button
    }
    void TaskOnClick()
    {
        Seleccion.gameObject.SetActive(false);
        Boton.gameObject.SetActive(false);
    }

    

}
