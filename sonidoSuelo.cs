using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonidoSuelo : MonoBehaviour
{
    public AudioSource error;

    public void sonidoError(){

        Debug.Log("aver aver");
        error.Play();
    }
}
