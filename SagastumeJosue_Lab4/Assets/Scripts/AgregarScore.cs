using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgregarScore : MonoBehaviour
{

    public int Puntaje = 1;


    void OnDestroy()
    {
        GameController.Score += Puntaje;
    }
    // Start is called before the first frame update
    void Start()
    {
        GameController.Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
