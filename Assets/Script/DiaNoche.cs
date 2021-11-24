using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiaNoche : MonoBehaviour
{
    public float minuto, grado, tiempoVelocidad = 1f;
    public Light luna;
    public float cantidadmenos = 0.5f;
    public Text txtdianoche;
    public GameObject riegoo;

    public Riego riego = new Riego();

    // Update is called once per frame
    void Update()
    {
        minuto += tiempoVelocidad * Time.deltaTime;
        if (minuto >= 1440)
        {
            minuto = 0;
        }
        grado = minuto / 4;
        this.transform.localEulerAngles = new Vector3(grado, 0f, 0f);
      
        if (grado >= 180)
        {
            this.GetComponent<Light>().enabled = false;
            luna.enabled = true;
            txtdianoche.text = "Noche";
            GetComponent<Riego>().AumentarNivel(cantidadmenos);
            riegoo.SetActive(true);
        }
        else
        {
            this.GetComponent<Light>().enabled = true;
            luna.enabled = false;
            txtdianoche.text = "Dia";
            GetComponent<Riego>().RestarNivel(cantidadmenos);
            riegoo.SetActive(false);
        }
    }
}