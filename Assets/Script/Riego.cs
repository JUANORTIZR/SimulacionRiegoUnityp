using System;
using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Riego : MonoBehaviour
{
    public int nivelMax;
    public float nivelActual, tiempoRiego = 1f;
    public Image imagenNivel;
    public bool tocarSuelo = false;
    // Start is called before the first frame update
    void Start()
    {
        nivelActual = nivelMax;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateNivel();
    }

    public void UpdateNivel()
    {
        imagenNivel.fillAmount = nivelActual / nivelMax;
    }

    public void RestarNivel(float cantidad)
    {
        if (!tocarSuelo && nivelActual > 0)
        {
            nivelActual -= cantidad;
            StartCoroutine(TocarSueloTiempo());
        }
    }
     public void AumentarNivel(float cantidad)
    {
        if (!tocarSuelo && nivelActual < 100)
        {
            nivelActual += cantidad;
            StartCoroutine(TocarSueloTiempo());
        }
    }

    IEnumerator TocarSueloTiempo(){
        tocarSuelo = true;
        yield return new WaitForSeconds(tiempoRiego);
        tocarSuelo = false;
    }
}
