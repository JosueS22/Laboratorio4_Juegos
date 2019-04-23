using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jet : MonoBehaviour
{
    public Vector3 startPos = new Vector3();
    void Start()
    {
        startPos = transform.position;
    }
    
    void Update()
    {
        transform.position = startPos + new Vector3(Mathf.Cos(2 * Time.time), 0, 2 * Mathf.Sin(2 * Time.time));
    }
}
