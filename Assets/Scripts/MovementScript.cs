using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovementScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            transform.Translate(transform.forward * Time.deltaTime *3);

        if (Input.GetKey(KeyCode.S))
            transform.position -= new Vector3(0, 0, 1);

           if (Input.GetKey(KeyCode.D))
            transform.Rotate(0, 0.12f, 0);

        if (Input.GetKey(KeyCode.A))
            transform.Rotate(0, -0.15f, 0);

     


        if (Input.GetKeyDown(KeyCode.M))
        {
            if (GetComponent<MeshRenderer>().enabled)
            {
                GetComponent<MeshRenderer>().enabled = false;
            }
            else
            {
                GetComponent<MeshRenderer>().enabled = true;
            }
        }

    }
    void OnCollisionEnter(Collision collision)
    {
       
    }
    void OnCollisionExit(Collision collision)
    {
        
    }
    void OnCollisionStay(Collision collision)
    {
        
    }
}
