using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntos : MonoBehaviour
{
    public static int puntos = 0;
    public Text textoPuntos;

    public GameObject Nivelcompletado;
    public GameObject completado;

    public SiguienteNivel siguienteNivel;

    public Pelota pelota;

    public Transform contenedorBloques;
    public Barra barra;

    public sonidosFinPartida sonFinPartida;




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
                Nivelcompletado.SetActive(true);
            }  

            sonFinPartida.NivelCompletado();

            siguienteNivel.ActivarCarga();     
        }
    }
}
