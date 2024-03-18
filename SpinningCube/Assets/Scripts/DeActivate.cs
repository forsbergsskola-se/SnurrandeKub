using UnityEngine;
using UnityEngine.UI;

public class ClickToDeactivate : MonoBehaviour
{
    public GameObject clickToCrapText;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            {
                clickToCrapText.SetActive(false);
            }
        }
    }
}