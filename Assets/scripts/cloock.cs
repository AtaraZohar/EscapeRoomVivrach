using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cloock : MonoBehaviour
{
    public GameObject inputPic;
    public nextLevel myLevel;

    // Update is called once per frame
    void Update()
    {
        chackAnswer();
    }

   public void Button1 (){

      GameObject.Find("Button1").GetComponentInChildren<Text>().text = ((int.Parse(GameObject.Find("Button1").GetComponentInChildren<Text>().text)+1)%10).ToString();
     
    }

       public void Button2 (){
       GameObject.Find("Button2").GetComponentInChildren<Text>().text = ((int.Parse(GameObject.Find("Button2").GetComponentInChildren<Text>().text)+1)%10).ToString();
    }

       public void Button3 (){
      GameObject.Find("Button3").GetComponentInChildren<Text>().text = ((int.Parse(GameObject.Find("Button3").GetComponentInChildren<Text>().text)+1)%10).ToString();
    }

       public void Button4 (){
       GameObject.Find("Button4").GetComponentInChildren<Text>().text = ((int.Parse(GameObject.Find("Button4").GetComponentInChildren<Text>().text)+1)%10).ToString();
    }

        
   public void chackAnswer(){

       int one =int.Parse(GameObject.Find("Button1").GetComponentInChildren<Text>().text);
       int two =int.Parse(GameObject.Find("Button2").GetComponentInChildren<Text>().text);
       int three =int.Parse(GameObject.Find("Button3").GetComponentInChildren<Text>().text);
       int four =int.Parse(GameObject.Find("Button4").GetComponentInChildren<Text>().text);

       if (one == 1 && two ==5 && three==0 && four==0){
           inputPic.SetActive(true);
           myLevel.question3=true;
       }
    }
}