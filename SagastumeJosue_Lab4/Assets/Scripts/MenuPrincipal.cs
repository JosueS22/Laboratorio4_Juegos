using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuPrincipal : MonoBehaviour
{
    void Start()
    {
        
    }
    
    void Update()
    {
        
    }

    //Recibe como parametro el nombre de la escena
    public void CambiarEscena(string _newScene)
    {
        SceneManager.LoadScene(_newScene);
    }
}
