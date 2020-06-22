using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkSolved : MonoBehaviour
{
    public GameObject inputPic1;
    public GameObject inputPic2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(roomMeneger.isSolved==true){
            inputPic2.SetActive(false);
            inputPic1.SetActive(true);
        }
    }
}
