using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esfera : MonoBehaviour
{
    public Rigidbody rb;
    public float force = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Ray myRay = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;

        if(Physics.Raycast(myRay, out hitInfo))
        {
            rb.AddForce(-hitInfo.normal * force, ForceMode.Impulse);
        }
    }

    void OnMouseOver()
    {
        GetComponent<MeshRenderer>().material.color = Color.green;
    }

    void OnMouseExit()
    {
        GetComponent<MeshRenderer>().material.color = Color.blue;
    }
}
