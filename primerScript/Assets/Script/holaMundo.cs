using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class holaMundo : MonoBehaviour
{

    int x; // solamente se esta declarando la variable 

    // Start is called before the first frame update
    void Start()
    {
        x = 0; // se esta agregando un valor 

        print("Mensaje en desuso");
        Debug.Log("Hola mundo desde Unity");
        Debug.LogError("Error a la hora de programar");
        Debug.LogWarning("Nota de la programacion");
    }

    // Update is called once per frame
    void Update()
    {
        // se sumara un valor cada que se ejecute o casa 1s
        //x = x + 1;

        // Debug.Log(x); // en este caso se esta imprimiendo para poder ver el valor en consola
        Debug.Log("Hola desde Update");
    }

    // orden de las funciones 
    private void FixedUpdate()
    {
        Debug.LogWarning("Hola desde Fixed Update cada 50 frames");
    }

    private void LateUpdate()
    {
        Debug.Log("Hola desde Late Update ");
    }

    private void OnEnable()
    {
        Debug.LogWarning("El objeto ha sido habilitado ");
    }

    private void OnDisable()
    {
        Debug.Log("El objeto ha sido inhabilitado ");
    }
}
