using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelRiddleAnimals : MonoBehaviour
{
public bool isClicked= false;
    public GameObject inputPic;
    public nextRoomAnimals next;
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
            inputPic.SetActive(true);
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
            if(myNum==10){
                next.num10=true;
            }
            if(myNum==11){
                next.num11=true;
            }
            if(myNum==12){
                next.num12=true;
            }      
        }
             else if (isClicked==false){
            inputPic.SetActive(false);
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
             if(myNum==10){
                next.num10=false;
            }
            if(myNum==11){
                next.num11=false;
            }
            if(myNum==12){
                next.num12=false;
            }  
        }
}
}
