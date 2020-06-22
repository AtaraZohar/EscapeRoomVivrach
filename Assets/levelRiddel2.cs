using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelRiddel2 : MonoBehaviour
{
    public bool isClicked= false;
    public GameObject inputPic1;
    public GameObject inputPic2;
    public nextRoom next;
    public int myNum;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        showPic();
    }

    public void changeBool(){
        if (isClicked==true){
            isClicked=false;
        }
        else if (isClicked==false){
            isClicked=true;
        }
    }

public void showPic(){
        if (isClicked==true){
            inputPic1.SetActive(true);
            inputPic2.SetActive(false);
            if(myNum==1){
                next.num1=true;
            }
            if(myNum==2){
                next.num2=true;
            }
            if(myNum==3){
                next.num3=true;
            }
            if(myNum==4){
                next.num4=true;
            }
            
            if(myNum==5){
                next.num5=true;
            }
            
            if(myNum==6){
                next.num6=true;
            }
            
            if(myNum==7){
                next.num7=true;
            }
            if(myNum==8){
                next.num8=true;
            }
            if(myNum==9){
                next.num9=true;
            }       
        }
             else if (isClicked==false){
           inputPic1.SetActive(false);
            inputPic2.SetActive(true);
             if(myNum==1){
                next.num1=false;
            }
            if(myNum==2){
                next.num2=false;
            }
            if(myNum==3){
                next.num3=false;
            }
            if(myNum==4){
                next.num4=false;
            }
            
            if(myNum==5){
                next.num5=false;
            }
            
            if(myNum==6){
                next.num6=false;
            }
            
            if(myNum==7){
                next.num7=false;
            }
            if(myNum==8){
                next.num8=false;
            }
            if(myNum==9){
                next.num9=false;
            }     
        }
}
}
