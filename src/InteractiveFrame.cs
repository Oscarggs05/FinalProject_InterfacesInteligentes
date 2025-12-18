using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractiveFrame : MonoBehaviour
{
    [Header("Escena a cargar")]
    [SerializeField] private string escenaDestino; // Nombre de la escena que se cargará

    [Header("Opcional: etiquetas de bala")]
    [SerializeField] private string tagBala = "Bullet"; // La etiqueta que deben tener las balas

    private void OnCollisionEnter(Collision collision)
    {
        // Verificamos que el objeto que colisiona tenga la etiqueta correcta
        if (collision.gameObject.CompareTag(tagBala))
        {
            if (!string.IsNullOrEmpty(escenaDestino))
            {
                // Cargamos la escena indicada
                SceneManager.LoadScene(escenaDestino);
            }
            else
            {
                Debug.LogWarning("No se ha asignado ninguna escena en MarcoInteractivo.");
            }
        }
    }
}
