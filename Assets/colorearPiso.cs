using UnityEngine;
using UnityEngine.UI;

public class colorearPiso : MonoBehaviour
{
    public Renderer[] pis1;
    public Renderer[] pis2;
    public Renderer[] pis3;
    public Renderer[] pis4;
    public Renderer[] pis5;
    public Renderer[] pis6;
    public GameObject Torre1Piso1;
    public GameObject Torre1Piso2;
    public GameObject Torre1Piso3;
    public GameObject Torre1Piso4;
    public GameObject Torre1Piso5;
    public GameObject Torre1Piso6;
    public float speed = 5f;
    public Dropdown NumeroPiso;

    // Start is called before the first frame update
    private void Start()
    {
     
    }

    private void Cambiar()
    {
        foreach (Renderer aaa in pis1)
        {
            //buscar la posicion x con el debug log para las torres
            aaa.transform.position = new Vector3(121.6f, aaa.transform.position.y, aaa.transform.position.z);
        }
        foreach (Renderer aaa in pis2)
        {
            aaa.transform.position = new Vector3(121.6f, aaa.transform.position.y, aaa.transform.position.z);
        }
        foreach (Renderer aaa in pis3)
        {
            aaa.transform.position = new Vector3(121.6f, aaa.transform.position.y, aaa.transform.position.z);
        }
        foreach (Renderer aaa in pis4)
        {
            aaa.transform.position = new Vector3(121.6f, aaa.transform.position.y, aaa.transform.position.z);
        }
        foreach (Renderer aaa in pis5)
        {
            aaa.transform.position = new Vector3(121.6f, aaa.transform.position.y, aaa.transform.position.z);
        }
        foreach (Renderer aaa in pis6)
        {
            aaa.transform.position = new Vector3(121.6f, aaa.transform.position.y, aaa.transform.position.z);

        }
    }

    // Update is called once per frame
    private void Update()
    {
        switch (NumeroPiso.value)
        {
            case 1:
                Cambiar();
                pis1 = Torre1Piso1.GetComponentsInChildren<Renderer>();
                

                foreach (Renderer aaa in pis1)
                {
                    

                    //Debug.Log(aaa.transform.position.x);
                    aaa.transform.position = new Vector3( aaa.transform.position.x - 5f, aaa.transform.position.y, aaa.transform.position.z);
                    //aaa.material.SetColor("_Color", Color.white);
                }
                break;

            case 2:
                Cambiar();
                pis2 = Torre1Piso2.GetComponentsInChildren<Renderer>();

                foreach (Renderer aaa in pis2)
                {
                    aaa.transform.position = new Vector3(115f, aaa.transform.position.y, aaa.transform.position.z);
                }
                break;

            case 3:
                Cambiar();
                pis3 = Torre1Piso3.GetComponentsInChildren<Renderer>();

                foreach (Renderer aaa in pis3)
                {
                    aaa.transform.position = new Vector3(115f, aaa.transform.position.y, aaa.transform.position.z);
                }
                break;

            case 4:
                Cambiar();
                pis4 = Torre1Piso4.GetComponentsInChildren<Renderer>();

                foreach (Renderer aaa in pis4)
                {
                    aaa.transform.position = new Vector3(115f, aaa.transform.position.y, aaa.transform.position.z);
                }
                break;

            case 5:
                Cambiar();
                pis5 = Torre1Piso5.GetComponentsInChildren<Renderer>();

                foreach (Renderer aaa in pis5)
                {
                    aaa.transform.position = new Vector3(115f, aaa.transform.position.y, aaa.transform.position.z);
                }
                break;

            case 6:
                Cambiar();
                pis6 = Torre1Piso6.GetComponentsInChildren<Renderer>();

                foreach (Renderer aaa in pis6)
                {
                    aaa.transform.position = new Vector3(115f, aaa.transform.position.y, aaa.transform.position.z);
                }
                break;

        }
    }
}