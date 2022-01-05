using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assigment.GameControllers
{
    public class GameOverManager : MonoBehaviour
    {
        public void RestartMethod()
        {
            SceneManager.LoadScene("Asteroids");
        }
        public void QuitMethod()
        {
            Application.Quit();
        }
    }
}
