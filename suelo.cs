using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class suelo : MonoBehaviour
{
    public vidas Vidas;

   void OnTriggerEnter(){
       
        Vidas.PerderVida();

   }
    
}
