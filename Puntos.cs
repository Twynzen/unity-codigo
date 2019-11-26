using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntos : MonoBehaviour
{
    public static int puntos = 0;
    public Text textoPuntos;

    public GameObject Nilvecompletado;
    public GameObject completado;

    public SiguienteNivel siguienteNivel;

    public Pelota pelota;

    public Transform contenedorBloques;
    public Barra barra;




    void Start()
    {
        ActualizarMarcadorPuntos(); 
    }

    void ActualizarMarcadorPuntos(){
        textoPuntos.text="Puntos: " + Puntos.puntos;
    }

    public void GanarPunto(){

        Puntos.puntos++;
        ActualizarMarcadorPuntos();

        if (contenedorBloques.childCount <= 0)
        {
            pelota.DetenerMovimiento();
            barra.enabled = false;     
            if (siguienteNivel.EsUltimoNivel())
            {
                completado.SetActive(true);
            }else
            {
                Nilvecompletado.SetActive(true);
            }  
            siguienteNivel.ActivarCarga();     
        }
    }
}
