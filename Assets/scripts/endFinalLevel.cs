using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endFinalLevel : MonoBehaviour
{

    public bool pic1;
    public bool pic2;
    public bool pic3;
    public GameObject inputPic1;
    public GameObject inputPic2;
    // Start is called before the first frame update
    void Start()
    {
        pic1=false;
        pic2=false;
        pic3=false;
    }

    // Update is called once per frame
    void Update()
    {
       isSolved(); 
    }

    public void isSolved(){
        if (pic1==true && pic2==true && pic3==true){
            inputPic1.SetActive(true);
            inputPic2.SetActive(true);
        }
    }
}
