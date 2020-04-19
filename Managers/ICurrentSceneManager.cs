using UnityEngine.SceneManagement;

namespace Managers
{
    public interface ICurrentSceneManager
    {
        string CurrentSceneName { get; }
        LoadSceneMode CurrentLoadSceneMode { get; }
        void LoadScene(string sceneName, LoadSceneMode mode);
    }
}