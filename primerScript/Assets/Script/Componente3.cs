using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Componente3 : MonoBehaviour
{

    // cambiar el nombre del objeto 
    private void Awake()
    {
        // Componente1.miObjeto.name = "NuevoNombreObjeto0";
    }

    // Start is called before the first frame update
    void Start()
    {
        Componente1.miObjeto.name = "NuevoNombreObjeto0";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
