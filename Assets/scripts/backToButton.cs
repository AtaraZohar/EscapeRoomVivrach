using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backToButton : MonoBehaviour
{

 [SerializeField] public int nextscene;

    public void moveScene()
    {
        SceneManager.LoadScene(nextscene);
    }
}
