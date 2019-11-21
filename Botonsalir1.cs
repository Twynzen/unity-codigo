using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botonsalir1 : MonoBehaviour
{
    public bool salir;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (salir){
            Debug.Log("Salimos del juego");
            Application.Quit();
            }else{
                
                Application.LoadLevel("Portada");

            }
        }
    }
}

