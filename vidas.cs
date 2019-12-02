using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class vidas : MonoBehaviour
{

    public static int Vidas = 3;

    public Text textoVidas;

    public Pelota pelota;

    public Barra barra;

    public GameObject Perdiste;
    public SiguienteNivel siguienteNivel;

    public sonidosFinPartida sonidoFinPartida;

    public sonidoSuelo sonidoErr;


    
    void Start()
    {
        ActualizarMarcadorVidas();
    }

    void ActualizarMarcadorVidas(){

        textoVidas.text = "Vidas: "+ vidas.Vidas;
    }
 
    public void PerderVida(){

        if (Vidas <= 0) return;
        
        vidas.Vidas--;
        ActualizarMarcadorVidas();

        if (Vidas <= 0)
        {   
            sonidoFinPartida.GameOver();
            //Mostramos el perdiste
            Perdiste.SetActive(true);
            sonidoErr.sonidoError();
            pelota.DetenerMovimiento();
            barra.enabled = false;

            siguienteNivel.nivelACargar = "Portada";
            siguienteNivel.ActivarCarga();

        }else
        {
            
            barra.Reset();
            pelota.Reset();
            sonidoErr.sonidoError();
        }

        barra.Reset();
        pelota.Reset();

    }
}
