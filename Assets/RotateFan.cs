using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateFan : MonoBehaviour
{
    public float velocidadRotacion = 100f; // Velocidad de rotación en grados por segundo

    void Update()
    {
        // Rotar el objeto sobre el eje Y
        transform.Rotate(0f, velocidadRotacion * Time.deltaTime, 0f);
    }
}
