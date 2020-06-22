using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
 
public class rotate : MonoBehaviour
{

    public GameObject inputPic;
    public nextLevel next;
 
    public float rotateSpeed = 180f;
 
 
    // Use this for initialization
    void Start () {
 
    }
 
    void Update () {
        isSolved();
    }
 
    public void OnClickLeft () {
       if(next.question2==false && next.question3 ==false){
        transform.Rotate(Vector3.forward*rotateSpeed*Time.deltaTime*1.5f);
       }
 
    }
   
   public void isSolved(){
       if(Math.Abs(gameObject.transform.rotation.eulerAngles.z)<182&&Math.Abs(gameObject.transform.rotation.eulerAngles.z)>176){
           next.question2=true;
           next.question3=true;
           inputPic.SetActive(true);
       }
   }
}
