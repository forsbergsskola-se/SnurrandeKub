using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryScript : MonoBehaviour
{
    public Color[] colors;
    public GameObject itemPrefab;

    public Transform contentParent;
    // Start is called before the first frame update
    void Start()
    {
        foreach (Color color in colors)
        {
            var item = Instantiate(itemPrefab, contentParent);
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
