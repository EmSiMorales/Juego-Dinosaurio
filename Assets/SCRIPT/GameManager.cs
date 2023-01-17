using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instancia;
    [SerializeField] public int mejorPuntuacion, puntuacionActual;
    // Start is called before the first frame update
    public static object Istancia { get; internal set; }

    private void Awake()
    {
        if (Instancia == null)
        {
            Instancia = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }
        mejorPuntuacion = PlayerPrefs.GetInt("mejorPuntuacion");
    }
    public void SumarPuntos(int puntos)
    {
        puntuacionActual += puntos;
        if (puntuacionActual > mejorPuntuacion)
        {
            mejorPuntuacion = puntuacionActual;
            PlayerPrefs.SetInt("mejorPuntuacion", mejorPuntuacion);
        }
    }
}
