using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class click : MonoBehaviour
{

    public GameObject inputImg;
    
    void Start()
    {
        void OnPointerClick(PointerEventData eventData)
        {
            Debug.Log("enter");
            inputImg.SetActive(true);
         }
    }
    
}

