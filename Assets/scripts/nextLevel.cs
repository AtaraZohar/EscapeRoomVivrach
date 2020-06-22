using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextLevel : MonoBehaviour
{
    public GameObject inputPic1;
    public GameObject inputPic2;
    public bool question1;
    public bool question2;
    public bool question3;
    public bool solvesRoom=false;

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
            roomMeneger.isSolved=true;
            inputPic1.SetActive(true);
            inputPic2.SetActive(true);
        }
    }
}
