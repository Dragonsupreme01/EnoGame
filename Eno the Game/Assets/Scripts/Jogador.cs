using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    private CharacterController _controlador;
    public float _velocidade = 10f;
    public float _gravidade = 9.81f;

    // Use this for initialization
    void Start()
    {
        _controlador = GetComponent<CharacterController>();

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        CalcularMovimento();

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }

    private void CalcularMovimento()
    {
        float entradaHorizontal = Input.GetAxis("Horizontal");
        float entradaVertical = Input.GetAxis("Vertical");
        Vector3 direcao = new Vector3(entradaHorizontal, 0, entradaVertical);
        Vector3 velocidade = direcao * _velocidade;
        velocidade.y -= _gravidade;

        velocidade = transform.transform.TransformDirection(velocidade);
        _controlador.Move(velocidade * Time.deltaTime);
    }
}
