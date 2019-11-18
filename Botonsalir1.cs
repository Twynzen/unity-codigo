using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Botonsalir1 : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Salimos del juego");
            Application.Quit();
        }
    }
}

