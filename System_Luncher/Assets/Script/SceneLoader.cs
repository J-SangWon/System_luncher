using UnityEngine;
using UnityEngine.SceneManagement;

public enum SceneType
{
    Title,
    Lobby,
    InGame,
}

public class SceneLoader : SingletonBehaviour<SceneLoader>
{
   public void LoadScene(SceneType sceneType)
    {
        Logger.Log($"Loading scene: {sceneType}");

        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneType.ToString());
    }
    public void ReLoadScene(SceneType sceneType)
    {
        Logger.Log($"Loading scene: {SceneManager.GetActiveScene().name}");

        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }


}
