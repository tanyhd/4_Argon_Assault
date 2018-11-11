using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {

    void Start()
    {
        Invoke("LoadStartScene", 5f);
    }

    void LoadStartScene()
    {
        SceneManager.LoadScene(1);
    }
}
