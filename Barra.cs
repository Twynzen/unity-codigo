using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barra : MonoBehaviour
{   
    public float velocidad = 0.4f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }

  
    void Update()
    {
        //el getaxisRaw recibimos un valor -1 si se esta pulsando 0 si no se pulza nada y 1 si se esta pulsando el eje positivo
        float tecladoHorizontal = Input.GetAxisRaw("Horizontal");
        float posX = transform.position.x + (tecladoHorizontal * velocidad* Time.deltaTime);
        Debug.Log("Uptade");
    }
}
