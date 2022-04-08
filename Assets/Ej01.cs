// 1.Crea un programa que permita ingresar por Inspector dos valores enteros y responda si son iguales o no lo son.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej01 : MonoBehaviour
{
    public int var1;
    public int var2;

    // Start is called before the first frame update
    void Start()
    {
        if (var1 == var2)
        {
            Debug.Log("Ambos valores son iguales!");
        } else
        {
            Debug.Log("Los valores no son iguales");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
