using UnityEngine;

public class DestruirAlEntrar : MonoBehaviour
{
    // Este método se ejecuta cuando algo entra en el "trigger" del objeto
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verificamos si el objeto que entra tiene la etiqueta "Player"
        if (other.CompareTag("Player"))
        {
            // Si el Player toca este objeto (hamburguesa o RedBull),
            // destruimos ESTE objeto, no el jugador.
            Destroy(gameObject);
        }
    }

    /*void OnTriggerEnter2D(Collider2D RedBull)
    {
        // Si quieres que desaparezca con cualquier cosa que tenga trigger
        Destroy(RedBull.gameObject);
    }


    //metodo para colision 2D sin trigger
    void OnCollisionEnter2D(Collision2D RedBull)
    {
        // Si quieres que desaparezca con cualquier cosa que tenga collider
        Destroy(RedBull.gameObject);
    }
    {
        // Si quieres que desaparezca con cualquier cosa 
        if (RedBull.gameObject.CompareTag("Player"))
        {
            Destroy(RedBull.gameObject);
        }
    }*/
}
