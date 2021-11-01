using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class select_tower : MonoBehaviour, IPointerClickHandler
{
    public int Index;
    public Place_Tower selection;

    public void OnPointerClick(PointerEventData eventData)
    {
        selection.selected = Index;
    }
    
}
