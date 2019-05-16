using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseY : MonoBehaviour
{

    // Use this for initialization
    public float _sensibilidade = 5f;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float _mouseY = Input.GetAxis("Mouse Y");

        Vector3 novaRotacao = transform.localEulerAngles;
        novaRotacao.x -= _mouseY * _sensibilidade;
        transform.localEulerAngles = novaRotacao;
    }
}
