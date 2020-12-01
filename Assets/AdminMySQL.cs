using UnityEngine;
using MySql.Data;
using MySql.Data.MySqlClient;

public class AdminMySQL : MonoBehaviour
{
    private string datosConexion;
    private MySqlConnection conexion;

    // Start is called before the first frame update
    void Start()
    {
        datosConexion = "Server=localhost;Database=unity;Uid=root;Pwd=root;";
            
        ConectarConServidorBaseDatos();
    }
    
    private void ConectarConServidorBaseDatos()
    {
        conexion = new MySqlConnection(datosConexion);

        try
        {
            conexion.Open();
            Debug.Log("Conexion realizada;");
        }
        catch(MySqlException error)
        {
            Debug.LogError("Imposible conectar con base de datos:" + error);
        }
        
    }

    public MySqlDataReader Select(string _select)
    {
        MySqlCommand cmd = conexion.CreateCommand();
        cmd.CommandText = "SELECT * FROM " + _select;
        MySqlDataReader Resultado = cmd.ExecuteReader();
        return Resultado;
    }

    public MySqlDataReader Insert(string _select)
    {
        MySqlCommand cmd = conexion.CreateCommand();
        cmd.CommandText = "INSERT INTO" + _select;
        MySqlDataReader Resultado = cmd.ExecuteReader();
        return Resultado;
    }
}