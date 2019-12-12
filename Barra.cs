using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barra : MonoBehaviour
{

    public float velocidad = 0.4f;

    public Vector3 posicionInicial;

    public ElementoInteractivo botonIz;
    public ElementoInteractivo botonDe;

    void Start()
    {
       posicionInicial = transform.position;
    }
    public void Reset()
    {
        transform.position = posicionInicial;
    }
  
    void Update()
    {
        float direccion;
        if (botonIz.pulsado)
        {
            direccion = -1;
        }else if (botonDe.pulsado)
        {

            direccion = 1;

        }else{

            direccion = Input.GetAxisRaw("Horizontal");
        }

        //Esta funcionalidad hace lo mismo que  todo el metodo anterior
        //float direccion = botonIz.pulsado ?
        // -1 : 
        //  (botonDe.pulsado ?
        //   1: Input.GetAxisRaw("Horizontal"));

        //float tecladoHorizontal = Input.GetAxisRaw("Horizontal");
        float posX = transform.position.x + (direccion * velocidad *Time.deltaTime);
        transform.position = new Vector3(Mathf.Clamp(posX, -8, 8), transform.position.y, transform.position.z);

    }
}
