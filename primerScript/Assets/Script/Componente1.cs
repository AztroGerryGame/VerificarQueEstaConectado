using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Componente1 : MonoBehaviour
{

    // Variable de tipo publico o estatico 
    // este objeto inica en memoria
    public static GameObject miObjeto;

    private void Awake()
    {
        miObjeto = this.gameObject;
    }

    // Start is called before the first frame update
    void Start()
    {
        // Se inicializa el objeto 
        // this referencia al script o instancia
        // miObjeto = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
