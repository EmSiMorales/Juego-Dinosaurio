using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUNTOS : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.tag == "Puntos")
        {
            GameManager.Instancia.SumarPuntos(1);
            gameObject.SetActive(false);
        }
    }
}