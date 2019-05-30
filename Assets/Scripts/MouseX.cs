using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseX : MonoBehaviour
{

    public float _sensibilidade = 5f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float _mouseX = Input.GetAxis("Mouse X");

        Vector3 novaRotacao = transform.localEulerAngles;
        novaRotacao.y += _mouseX * _sensibilidade;
        transform.localEulerAngles = novaRotacao;
    }
}
