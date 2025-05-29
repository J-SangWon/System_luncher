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
    public static SceneLoader instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
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

    public AsyncOperation LoadSceneAsync(SceneType sceneType)
    {
        Logger.Log($"{sceneType} scene loading...");
        Time.timeScale = 1f;

        return SceneManager.LoadSceneAsync(sceneType.ToString());
    }


}
