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
    // Start is called before the first frame update
    void Start()
    {
        ActualizarMarcadorVidas();
    }

    void ActualizarMarcadorVidas(){

        textoVidas.text = "Vidas: "+ vidas.Vidas;
    }
 
    public void PerderVida(){

        vidas.Vidas--;
        ActualizarMarcadorVidas();
        barra.Reset();
        pelota.Reset();

    }
}
