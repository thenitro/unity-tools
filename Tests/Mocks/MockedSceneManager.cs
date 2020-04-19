using Managers;
using UnityEngine.SceneManagement;

namespace Tests.Editor.Mocks
{
    public class MockedSceneManager : ICurrentSceneManager
    {
        public string CurrentSceneName { get; private set;  }
        public LoadSceneMode CurrentLoadSceneMode { get; private set;  }

        public void LoadScene(string sceneName, LoadSceneMode mode)
        {
            CurrentSceneName = sceneName;
            CurrentLoadSceneMode = mode;
        }
    }
}