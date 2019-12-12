using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;

// IPointerDownHandler, IPointerUpHandler estos objetos son para el tactil creo

public class ElementoInteractivo : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public bool pulsado;

    public void OnPointerDown(PointerEventData eventData)
    {
        pulsado = true;   
    }
    
    public void OnPointerUp(PointerEventData eventData)
    {
        pulsado = false;
    }
    
}
