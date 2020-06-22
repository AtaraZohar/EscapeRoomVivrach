using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextRoomAnimals : MonoBehaviour
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
     public bool num10;  
    public bool num11;
    public bool num12;
    // Start is called before the first frame update
    void Start()
    {
        num1=false;
        num2=false;
        num3=false;
        num4=false;
        num5=false;
        num6=false;
        num7=false;
        num8=false;
        num9=false;
        num10=false;
        num11=false;
        num12=false;
    }

    // Update is called once per frame
    void Update()
    {
        solved();
    }

    public void solved(){
        if(num1==true&& num2==true&& num3==false&& num4==true&& num5==false&& num6==true&& num7==true && num8==false&& num9==true && num10==true && num11==false&& num12==false){
            inputPic2.SetActive(true);
            inputPic1.SetActive(true);
            inputPic3.SetActive(true);
        }
    }
}
