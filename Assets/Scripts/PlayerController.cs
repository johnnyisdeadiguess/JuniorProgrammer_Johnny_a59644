using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Estabelecer a velocidade do veículo e a velocidade com que vira para os lados
    private float speed = 5.0f;
    private float turnSpeed = 45.0f;

    //Estabelecer os movimentos para o carro conseguir virar para os lados e ir para a frente
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Estabelece os eixos que o carro irá seguir para conseguir se movimentar
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //Movimentar para a frente e trás, esquerda e direita
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up * turnSpeed * horizontalInput * Time.deltaTime);
    }

}
