// 2. Crear las variables necesarias para ingresar por Inspector el precio de 3 productos y un monto de dinero disponible. 
// Comunicar si la suma de los mismos supera o no el monto de dinero disponible.Luego indicar cuánto dinero sobra o falta.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej02 : MonoBehaviour
{
    public float prod1;
    public float prod2;
    public float prod3;
    public float precio_disponible;
    float precio_total;
    float diferencia;

    // Start is called before the first frame update
    void Start()
    {
        precio_total = prod1 + prod2 + prod3;

        if (precio_total > precio_disponible)
        {
            Debug.Log("El precio total supera el monto disponible");

            diferencia = precio_total - precio_disponible;

            Debug.Log("Faltan $" +diferencia );
        } else if (precio_total < precio_disponible)
        {
            Debug.Log("El precio total no supera el monto disponible");

            diferencia = precio_disponible - precio_total;

            Debug.Log("Sobran $" + diferencia);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
