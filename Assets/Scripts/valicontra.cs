using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class valicontra : MonoBehaviour
{
    string contracorrecta;
    string contraUsr;
    public Text ingresoUsr;

    // Start is called before the first frame update
    void Start()
    {
        contracorrecta = "1234";
    }
    

    // Update is called once per frame
    void Update(){
         }

    public void valiContra()
    {
        contraUsr = ingresoUsr.text;
        if (contraUsr == contracorrecta)
        {
            Debug.Log("Bienvenido");
        }
        else if (contraUsr != contracorrecta)
        {
            Debug.Log("Contraseña incorrecta");
        }
    }
}
