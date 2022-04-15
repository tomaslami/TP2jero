using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MayorEdad : MonoBehaviour
{
    public int edad_usuario;
    public Text mitexto;
    // Start is called before the first frame update
    void Start()
    {
        if (edad_usuario >= 18)
        {
            mitexto.text = "Es mayor de edad";
            Debug.Log("Es mayor de edad");
        } else {
            mitexto.text = "No es mayor de edad";
            Debug.Log("No es mayor de edad ");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
