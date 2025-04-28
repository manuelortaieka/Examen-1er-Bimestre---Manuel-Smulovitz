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
        if (pesoDeMudanza > 10000)
        {
            Debug.Log("El peso de su mudanza no puede ser superior a 10000 KG.");
        }
        if (pesoDeMudanza <= 2000)
        {
            cantHoras = 25 / distanciaEnKm;
            Debug.Log("El vehiculo necesario para su mudanza sera el utilitario, y dada su distancia " + distanciaEnKm + " el vehiculo durara " + 25 / distanciaEnKm + " horas.");
            if (cantHoras > 2) {
                Debug.Log("Su mudanza costara $6000");
            }
            if (distanciaEnKm > 50) {
                cantHoras = cantHoras + 1;
                Debug.Log("Precio total" + cantHoras + "horas a $" + precioHora + ": $" + cantHoras * 3000);
            }
            else {
                Debug.Log("Precio total" + cantHoras + "horas a $" + precioHora + ": $" + cantHoras * 3000);
            }
            if (pesoDeMudanza > 2000 && pesoDeMudanza <= 5000)
            {
                cantHoras = 25 / distanciaEnKm;
                Debug.Log("El vehiculo necesario para su mudanza sera el Pick Up, y dada su distancia " + distanciaEnKm + " el vehiculo durara " + 25 / distanciaEnKm + " horas.");
                if (cantHoras > 2)
                {
                    Debug.Log("Su mudanza costara $9000");
                }
                if (distanciaEnKm > 50)
                {
                    cantHoras = cantHoras + 1;
                    Debug.Log("Precio total" + cantHoras + "horas a $" + precioHora + ": $" + cantHoras * 4500);
                }
                else
                {
                    Debug.Log("Precio total" + cantHoras + "horas a $" + precioHora + ": $" + cantHoras * 4500);
                }
                if (pesoDeMudanza <= 2000)
                {
                    cantHoras = 25 / distanciaEnKm;
                    Debug.Log("El vehiculo necesario para su mudanza sera el utilitario, y dada su distancia " + distanciaEnKm + " el vehiculo durara " + 25 / distanciaEnKm + " horas.");
                    if (cantHoras > 2) {
                        Debug.Log("Su mudanza costara $6000");
                    }
                    if (distanciaEnKm > 50) {
                        cantHoras = cantHoras + 1;
                        Debug.Log("Precio total" + cantHoras + "horas a $" + precioHora + ": $" + cantHoras * 3000);
                    }
                    else {
                        Debug.Log("Precio total" + cantHoras + "horas a $" + precioHora + ": $" + cantHoras * 3000);
                    }
                    if (pesoDeMudanza > 5000 && pesoDeMudanza <= 10000)
                    {
                        cantHoras = 25 / distanciaEnKm;
                        Debug.Log("El vehiculo necesario para su mudanza sera el camion, y dada su distancia " + distanciaEnKm + " el vehiculo durara " + 25 / distanciaEnKm + " horas.");
                        if (cantHoras > 2)
                        {
                            Debug.Log("Su mudanza costara $14000");
                        }
                        if (distanciaEnKm > 50)
                        {
                            cantHoras = cantHoras + 1;
                            Debug.Log("Precio total" + cantHoras + "horas a $" + precioHora + ": $" + cantHoras * 7000);
                        }
                        else
                        {
                            Debug.Log("Precio total" + cantHoras + "horas a $" + precioHora + ": $" + cantHoras * 7000);
                        }

                    }
                }





            }

            // Update is called once per frame
            void Update()
            {

            }
        }

