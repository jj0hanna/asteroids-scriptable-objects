using UnityEngine;

namespace Assigment.GameControllers
{
    public class Game : MonoBehaviour
    {
        [SerializeField] private GameObject gameOverPanel;
        void Start()
        {
          gameOverPanel.SetActive(false);
          Time.timeScale = 1;
        }

        public void GameOver()
        {
            gameOverPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
