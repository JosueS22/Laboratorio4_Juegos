﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OnScreenMenu : MonoBehaviour
{
    
    void Start()
    {
        
    }
    
    void Update()
    {
        
    }

    public void Reiniciar()
    {
        SceneManager.LoadScene("Laberinto");
    }
    
}
