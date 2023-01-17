using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ENEMIGO : MonoBehaviour
{
    [SerializeField] Camera camara;
    [SerializeField] Vector2 posicionMinima;
    [SerializeField] float Velocidad;
    [SerializeField] Vector3 posicionInicial;
    [SerializeField] AudioClip[] sonidos;
    [SerializeField] AudioSource audiosource;
    // Start is called before the first frame update
    void Start()
    {
        //Cogemos la camara
        camara = Camera.main;
        posicionMinima = camara.ViewportToWorldPoint(new Vector2(0, 0));
        posicionInicial = transform.position;
        audiosource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * Velocidad);
        if (transform.position.x < posicionMinima.x)
        {
            transform.position = posicionInicial;
            Velocidad += 1;

        }   
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "puntos")
        {
            GameManager.Instancia.ActualizarPuntuacion();
            audiosource.clip = sonidos[0];
            audiosource.Play();
        }
    }
    public void Reiniciar()
    {
        transform.position = posicionInicial;
        Velocidad = 4;
    }
}