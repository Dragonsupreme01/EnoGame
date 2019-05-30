using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    private CharacterController _controlador;
    public float _velocidade = 40f;
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

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            _velocidade += 30f;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            _velocidade -= 30f;
        }
    }

    public AudioClip[] arrayDeSoms; // de 5 tipos de passos
    private void CalcularMovimento() 
    {
        /* Se apertou AWSD(MOVIMENTO)
        Verificar TAG == Chão Se for {
        Pegar som aleatorio de um array de sons de passo
        } se não {
        Pegar som aleatorio de um array de sons de passos
        }
       */
        AudioClip g = arrayDeSoms[UnityEngine.Random.Range(0, arrayDeSoms.Length)];
        AudioSource.PlayClipAtPoint(g, transform.position);
        float entradaHorizontal = Input.GetAxis("Horizontal");
        float entradaVertical = Input.GetAxis("Vertical");
        Vector3 direcao = new Vector3(entradaHorizontal, 0, entradaVertical);
        Vector3 velocidade = direcao * _velocidade;
        velocidade.y -= _gravidade;

        velocidade = transform.transform.TransformDirection(velocidade);
        _controlador.Move(velocidade * Time.deltaTime);
    }
}
