using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireParticleCollision : MonoBehaviour
{
    public GameObject fireObject; // El objeto que se activará al colisionar
    private ParticleSystem particleSystemFire; // Referencia al sistema de partículas

    private void Start()
    {
        particleSystemFire = fireObject.GetComponent<ParticleSystem>();
    }
    void OnTriggerEnter(Collider other)
    {
        // Comprueba si el objeto con el que colisiona tiene el tag "FireParticle"
        if (other.gameObject.CompareTag("FireParticle"))
        {
            // Imprime un mensaje en la consola
            Debug.Log("Está colisionando con FireParticle");
            fireObject.SetActive(true);
            particleSystemFire.Play();
        }
    }
}
