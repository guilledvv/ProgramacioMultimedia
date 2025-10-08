using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Aquí ponemos al jugador (el objeto que la cámara va a seguir)
    public Transform Player;

    // Esto se ejecuta después de que el jugador se mueva
    void LateUpdate()
    {
        // Si no hay jugador, no hacer nada (evita errores)
        if (Player == null)
            return;

        // Hacemos que la posición de la cámara sea igual a la del jugador
        // Así la cámara se "pega" al jugador
        transform.position = Player.position;
    }
}
