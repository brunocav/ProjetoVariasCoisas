using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento2 : MonoBehaviour {
    public float yRotation = 50.0F;

    public float velocidade = 2000;
    public float acelerecao = 1000;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * velocidade * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-Vector3.forward * velocidade * Time.deltaTime);
        }
        yRotation += Input.GetAxis("Horizontal");
        transform.eulerAngles = new Vector3(0, yRotation, 0);
    }
    void Example()
    {
        print(transform.eulerAngles.x);
        print(transform.eulerAngles.y);
        print(transform.eulerAngles.z);
    }


}
