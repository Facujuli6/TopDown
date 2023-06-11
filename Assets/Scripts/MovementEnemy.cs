using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementEnemy : MonoBehaviour
{
    [SerializeField] Transform[] waypoints;
   Vector3 siguientePosicion;
     float velocidad = 2.0f;
    float distanciaCambio = 0.2f;
    int numeroSiguientePosicion = 0;
    void Start()
    {
        siguientePosicion = waypoints[0].position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, siguientePosicion, velocidad * Time.deltaTime);
        if (Vector3.Distance(transform.position, siguientePosicion) < distanciaCambio)
        {
            numeroSiguientePosicion ++;
            if (numeroSiguientePosicion >= waypoints.Length)
                numeroSiguientePosicion = 0;
            siguientePosicion = waypoints[numeroSiguientePosicion].position;
        }
    }
}
