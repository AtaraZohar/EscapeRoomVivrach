using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Implements a singleton pattern in Unity:
 * makes sure that there is exactly one GameObject with the same TAG of the current one.
 * 
 * @author Erel Segal-Halevi
 * @since 2020-02
 */
public class Singleton : MonoBehaviour {
    void Awake() {
        GameObject gameObject = GameObject.Find("nextLevelCanvas");

            DontDestroyOnLoad(gameObject);
    }
}
