using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RelojAnalogico : MonoBehaviour
{
    public Transform manecillaHoras;
    public Transform manecillaMinutos;
    public Transform manecillaSegundos;

    private const float gradosPorHora = 30f; // 360 grados / 12 horas
    private const float gradosPorMinutoYSegundo = 6f; // 360 grados / 60 minutos o segundos

    void Update()
    {
        ActualizarManecillas();
    }

    void ActualizarManecillas()
    {
        System.DateTime tiempoActual = System.DateTime.Now;

        float gradosSegundos = tiempoActual.Second * gradosPorMinutoYSegundo;
        float gradosMinutos = (tiempoActual.Minute + tiempoActual.Second / 60f) * gradosPorMinutoYSegundo;
        float gradosHoras = (tiempoActual.Hour % 12 + tiempoActual.Minute / 60f) * gradosPorHora;

        // Conservar la rotación original en los ejes X y Z y modificar solo el eje Y en el espacio global
        manecillaSegundos.localRotation = Quaternion.Euler(gradosSegundos,0,-90);
        manecillaMinutos.localRotation = Quaternion.Euler(gradosMinutos,0,-90);
        manecillaHoras.localRotation = Quaternion.Euler(gradosHoras,0,-90);
    }
}
