using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextRoom : MonoBehaviour
{
    public GameObject inputPic1;
    public GameObject inputPic2;
    public GameObject inputPic3;
    public bool num1;
    public bool num2;
    public bool num3;
    public bool num4;
    public bool num5;
    public bool num6;
    public bool num7;  
    public bool num8;
    public bool num9;
    // Start is called before the first frame update
    void Start()
    {
        if (roomMeneger.isNumSolved==true){
            inputPic2.SetActive(true);
        }
        num1=false;
        num2=false;
        num3=false;
        num4=false;
        num5=false;
        num6=false;
        num7=false;
        num8=false;
        num9=false;
    }

    // Update is called once per frame
    void Update()
    {
        solved();
    }

    public void solved(){
        if(num1==false&& num2==false&& num3==true&& num4==false&& num5==false&& num6==false&& num7==false && num8==false&& num9==false){
            roomMeneger.isNumSolved=true;
            inputPic2.SetActive(true);
        }
        if(roomMeneger.isNumSolved==true&& roomMeneger.isSolved==true){
            inputPic1.SetActive(true);
            inputPic3.SetActive(true);
        }
    }
}
