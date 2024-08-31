using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desactivar : MonoBehaviour
{
    public float tiempoHastaDesactivar = 5f; // Tiempo en segundos antes de desactivar el objeto

    public void DesactivateObject()
    {
        // Llama al método DesactivarObjeto después de 'tiempoHastaDesactivar' segundos
        Invoke("DesactivarObjeto", tiempoHastaDesactivar);
    }

    private void DesactivarObjeto()
    {
        // Desactiva el objeto al que está adjunto el script
        gameObject.SetActive(false);
    }
}