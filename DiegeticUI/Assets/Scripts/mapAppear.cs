using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mapAppear : MonoBehaviour
{
    [SerializeField]
    private Image mapImage;


     void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            mapImage.enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            mapImage.enabled = false;
        }
    }
}
