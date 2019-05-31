using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovimentoTeste : MonoBehaviour
{

    public GameObject Jogador;
    private Vector3 _destino;
    private NavMeshAgent _agent;

    // Use this for initialization
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        _agent.destination = Jogador.transform.position;
        _destino = Jogador.transform.position;
        _agent.speed = 50f;
        _agent.acceleration = 50f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(_destino, transform.position) > 1.0f)
        {
            _destino = Jogador.transform.position;
            _agent.destination = _destino;
        }
    }
}
