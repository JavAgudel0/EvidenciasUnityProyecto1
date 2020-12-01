using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MySql.Data.MySqlClient;

public class Login : MonoBehaviour
{
    public InputField usuarioTxt;
    public InputField contraseñaTxt;
    public InputField confirmarContraseñaTxt;
    public InputField correoTxt;

    public GameObject _login;
    public GameObject _registro;

    
    public void Loggear()
    {
        string _log = "`usuarios` WHERE `usuario` LIKE '" + usuarioTxt.text +
                        "' and `contraseña` LIKE '" + contraseñaTxt.text + "'";

        AdminMySQL _adminMySQL = GameObject.Find("Database").GetComponent<AdminMySQL>();
        MySqlDataReader Resultado = _adminMySQL.Select(_log);

        if (Resultado.HasRows)
        {
            Debug.Log("Login correcto.");
            Resultado.Close();
        }
        else
        {
            Debug.Log("Usuario o contraseña incorrectos.");
            Resultado.Close();
            
        }

    }

    public void AbrirCerrarRegistro()
    {
        
    }
}
