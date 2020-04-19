using UnityEngine;

namespace Controllers
{
    public class DontDestroyController : MonoBehaviour
    {
        private void Awake()
        {
            DontDestroyOnLoad(this);
        }
    }
}