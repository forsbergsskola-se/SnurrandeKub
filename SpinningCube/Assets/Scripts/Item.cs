using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Item : MonoBehaviour, IBeginDragHandler    
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnBeginDrag(PointerEventData eventData) //What behavior do I want when someone wants to drag this item?
    {
        Debug.Log("Start Drag.");
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Dragging... now say 'springa bil snö penna' in english!");
    }
}
