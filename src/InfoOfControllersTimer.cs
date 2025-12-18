using System.Collections;
using UnityEngine;

public class InfoOfControllersTimer : MonoBehaviour
{
    public GameObject tutorialInfo;
    public GameObject tutorialInfo2;

    void Start()
    {
        // Aseguramos que ambos estén desactivados al inicio
        tutorialInfo.SetActive(false);
        tutorialInfo2.SetActive(false);

        StartCoroutine(TutorialSequence());
    }

    IEnumerator TutorialSequence()
    {
        // Activar TutorialInfo por 3 segundos
        yield return new WaitForSeconds(1f);
        tutorialInfo.SetActive(true);
        yield return new WaitForSeconds(3f);
        tutorialInfo.SetActive(false);
        yield return new WaitForSeconds(1f);
        // Activar TutorialInfo2 por 3 segundos
        tutorialInfo2.SetActive(true);
        yield return new WaitForSeconds(3f);
        tutorialInfo2.SetActive(false);
    }
}
