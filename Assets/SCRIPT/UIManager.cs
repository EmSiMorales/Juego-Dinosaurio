using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] TMP_Text puntuacionActual, mejorPuntuacion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        puntuacionActual.text = GameManager.Instancia.puntuacionActual.ToString();
        mejorPuntuacion.text = GameManager.Instancia.mejorPuntuacion.ToString();
    }
}
