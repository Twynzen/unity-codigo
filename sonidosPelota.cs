using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonidosPelota : MonoBehaviour{

    public AudioSource rebote;
    public AudioSource punto;

    void OnCollisionEnter(Collision otro){

        if (otro.gameObject.CompareTag("Bloque"))
        {   
            Debug.Log("pum");
            punto.Play();
        }
        else
        {
            rebote.Play(); 
        }

    }
}
