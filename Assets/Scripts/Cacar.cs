using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Cacar : MonoBehaviour
{

    public float velocidade = 20.0f;
    public float distanciaMinina = 1f;
    public Transform alvo;
    NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {

        agent = GetComponent<NavMeshAgent>();
        if(alvo == null){
            if (GameObject.FindWithTag("Player") != null)
            {
                alvo = GameObject.FindWithTag("Player").GetComponent<Transform>();
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (alvo == null)
        {
            Debug.Log("Não há alvo definido para caçar!!!");
            return;
        }

        transform.LookAt(alvo);

        float distancia = Vector3.Distance(transform.position, alvo.position);

        if (distancia > distanciaMinina)
            agent.SetDestination(alvo.position);
    }

    public void setAlvo(Transform novoAlvo)
    {
        alvo = novoAlvo;
    }
}
