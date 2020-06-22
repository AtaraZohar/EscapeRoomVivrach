using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class clickLock : MonoBehaviour
{
    // Start is called before the first frame update
    public Image img;
    public GameObject inputText;
    public GameObject inputPic;
    public int nextScene;



    public void moveScene()
    {
        SceneManager.LoadScene(nextScene);
    }

    public void showInput()
    {
        Debug.Log("clickk");
        inputText.SetActive(true);
    }

    public void showPic()
    {
        inputPic.SetActive(true);
    }

    public void unshowPic()
    {
        inputPic.SetActive(false);
    }




}
