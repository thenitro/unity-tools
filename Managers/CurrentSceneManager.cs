using UnityEngine.SceneManagement;

namespace Managers
{
    public class CurrentSceneManager : ICurrentSceneManager
    {
        public string CurrentSceneName { get; private set; }
        public LoadSceneMode CurrentLoadSceneMode { get; private set; }

        public void LoadScene(string sceneName, LoadSceneMode mode)
        {
            CurrentSceneName = sceneName;
            CurrentLoadSceneMode = mode;
            
            SceneManager.LoadScene(sceneName, mode);
        }
    }
}