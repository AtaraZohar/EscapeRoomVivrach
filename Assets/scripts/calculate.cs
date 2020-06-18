using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class calculate : MonoBehaviour
{
    public GameObject InputField;
    public GameObject inputPic;
    private bool isCorrectPassword = false;
    public int questionNum;
    public nextLevel myLevel;

    public string CorrectNumber;

    private string inputNumber;

    void Start()
    {
        
    }
    void Update()
    {
        
        VerifyNumber();
    }

    void VerifyNumber()
    {
        
        if (isCorrectPassword) return;

        if (Input.GetKey(KeyCode.Return))
        {
            inputNumber = InputField.transform.Find("Text").GetComponent<Text>().text;

            InputField.transform.Find("Text").GetComponent<Text>().text = "";

            if (inputNumber == CorrectNumber)
            {
                isCorrectPassword = true;
                Destroy(InputField);
                Debug.Log("password correct");
                inputPic.SetActive(true);
                if(questionNum==1){
                myLevel.question1=true;
                Debug.Log("ture");
                }
                  if(questionNum==2){
                myLevel.question2=true;
                Debug.Log("ture");
                }
            }
            
            
        }
    }
}
