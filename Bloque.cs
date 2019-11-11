using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque : MonoBehaviour
{

    public GameObject efectoParticulas;
    //el triger desactivado
    void OnCollisionEnter(){

        Instantiate(efectoParticulas, transform.position, Quaternion.identity);
        Destroy(gameObject);

    }

    /*el triger esta activado
    void OnTriggerEnter(){

        Debug.Log("TriggerEnter");

    }
*/
}
