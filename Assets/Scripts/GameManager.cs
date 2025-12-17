using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameObject player;

    [Header("Score")]
    public int score;

    private const string SCORE_KEY = "Score";

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        LoadScore();
    }

    public void AddScore(int amount)
    {
        score += amount;
        SaveScore();
    }

    public void SaveScore()
    {
        PlayerPrefs.SetInt(SCORE_KEY, score);
        PlayerPrefs.Save();
    }

    public void LoadScore()
    {
        score = PlayerPrefs.GetInt(SCORE_KEY, 0);
    }

    public void ResetScore()
    {
        score = 0;
        SaveScore();
    }
}
