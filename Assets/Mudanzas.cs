using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mudanzas : MonoBehaviour
{
    public float pesoDeMudanza;
    public float distanciaEnKm;
    float precioHora;
    float cantHoras;
    float precioTotalHoras;

    // Start is called before the first frame update
    void Start()
    {
        if (pesoDeMudanza < 100)
        {
            Debug.Log("El peso de su mudanza debe ser superior a los 100 KG.");
            return;
        }
        if (distanciaEnKm < 1)
        {
            Debug.Log("La distancia no puede ser menor a 1 KM.");
            return;
        }
        if (pesoDeMudanza <= 2000)
        {
            Debug.Log("El vehiculo necesario para su mudanza sera el utilitario, y dada su distancia " + distanciaEnKm + " el vehiculo durara " + 25 / distanciaEnKm + " horas");

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
