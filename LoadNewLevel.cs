using UnityEngine.SceneManagement;
using UnityEngine;

public class LoadNewLevel : MonoBehaviour
{
  void LoadNextLevel()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
