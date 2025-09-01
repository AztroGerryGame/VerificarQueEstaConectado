using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Componente2 : MonoBehaviour
{

    // se llama al objeto que se creo en el componente 1
    private void Awake()
    {
        // imprimir en pantalla el nombre del cubo 
        // .name es uno de los valores que tiene predefinido
        // Debug.Log(Componente1.miObjeto.name);
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Componente1.miObjeto.name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
