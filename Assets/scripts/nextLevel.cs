using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextLevel : MonoBehaviour
{
    public GameObject inputPic;
    public bool question1;
    public bool question2;
    public bool question3;

    // Start is called before the first frame update
    void Start()
    {
       question1=false;
        question2=false;
         question3=false; 
    }

    // Update is called once per frame
    void Update()
    {
     checkRight();   
    }

    public void checkRight(){
        if (question1 == true && question2 ==true && question3 ==true){
            inputPic.SetActive(true);
        }
    }
}
