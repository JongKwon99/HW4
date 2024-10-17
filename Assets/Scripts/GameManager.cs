using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private int enemyCount = 30; // ÃÑ ÀûÀÇ ¼ö
    private int enemiesDestroyed = 0; // ÆÄ±«µÈ ÀûÀÇ ¼ö

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void EnemyDestroyed()
    {
        enemiesDestroyed++;
        if (enemiesDestroyed >= 10)
        {
            Win();
        }
    }

    public void CheckLife(Life playerLife)
    {
        if (playerLife.amount <= 0)
        {
            Lose();
        }
    }

    private void Win()
    {
        Debug.Log("You Win!");
        SceneManager.LoadScene("Win");
    }

    private void Lose()
    {
        Debug.Log("You Lose!");
        SceneManager.LoadScene("Lose");
    }
}
