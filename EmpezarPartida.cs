﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmpezarPartida : MonoBehaviour
{

    public ElementoInteractivo pantalla;
   
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") || pantalla.pulsado)
        {
            Puntos.puntos = 0;
            vidas.Vidas = 3;
            Application.LoadLevel("Nivel1");
        }
    }
}
