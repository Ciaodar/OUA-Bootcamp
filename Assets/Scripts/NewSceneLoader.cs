using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewSceneLoader : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            LoadNextScene();
        }
    }
    public static void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public static IEnumerator NextSceneAfterDialogue(DialogueTrigger dialogueTrigger, float waitseconds = 1f)
    {
        dialogueTrigger.TriggerDialogue();
        yield return new WaitForSeconds(waitseconds);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public static IEnumerator YouLostScene()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene("Scenes/YouLost");
    }

    public static void ToMainMenu()
    {
        SceneManager.LoadScene("Scenes/MainMenu");
    }
}
