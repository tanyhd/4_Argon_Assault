﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicPlayer : MonoBehaviour {

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        Invoke("LoadStartScene", 5f);
    }

    void LoadStartScene()
    {
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    void Update()
    {

    }
}