using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SiguienteNivel : MonoBehaviour
{

    public string nivelACargar;
    public float retraso;
    [ContextMenu("Activar Carga")]
    public void ActivarCarga(){
        Invoke("CargarNivel", retraso);
    }

    void CargarNivel(){
        Application.LoadLevel(nivelACargar);
    }

    public bool EsUltimoNivel(){
        if (nivelACargar == "Portada")
        {
            return true;
        }else
        {
            return false;
        }
        
    }
}
