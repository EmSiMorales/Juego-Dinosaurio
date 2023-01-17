using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instancia;
    [SerializeField] public int mejorPuntuacion, puntuacionActual;
    [SerializeField] GameObject personaje, enemigo, boton, texto;
    [SerializeField] ENEMIGO Enemigo;
    // Start is called before the first frame update

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
    public void ReiniciarNivel()
    {
        personaje.SetActive(true);
        enemigo.SetActive(true);
        boton.SetActive(false);
        texto.SetActive(false);
        puntuacionActual = 0;
        Enemigo.Reiniciar();
    }
    public void Perder()
    {
        personaje.SetActive(false);
        enemigo.SetActive(false);
        boton.SetActive(true);
        texto.SetActive(true);
    }
    public void ActualizarPuntuacion()
    {
        puntuacionActual += 1;
        if (puntuacionActual > mejorPuntuacion)
        {
            mejorPuntuacion = puntuacionActual;
            PlayerPrefs.SetInt("mejorPuntuacion", mejorPuntuacion);
        }
    }
}
