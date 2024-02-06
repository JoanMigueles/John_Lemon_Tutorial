using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Follower : MonoBehaviour
{
    public GameObject player;
    public NavMeshAgent navMeshAgent;
    public Transform initialPosition;

    void Start()
    {
        transform.position = initialPosition.position;
    }

    void Update()
    {
        //Comprueba si el jugador se encuentra dentro de la malla de navegación y lo busca
        NavMeshHit hit;
        if (NavMesh.SamplePosition(player.transform.position, out hit, 1.0f, NavMesh.AllAreas)) {
            navMeshAgent.SetDestination(player.transform.position);
        }
        //Si no está en la malla, el fantasma regresa a su posición inicial
        else
        {
            navMeshAgent.SetDestination(initialPosition.position);
        }
    }
}
