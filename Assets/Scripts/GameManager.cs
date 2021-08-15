using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager instance = null;

    public bool youWin;
    public bool youLose;
    float countdown = 5;
    private int numeroDaFase = 0;

    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameObject("GM").AddComponent<GameManager>();
            }
            return instance;
        }
    }

    public int GetNumerodaFase()
    {
        return numeroDaFase;
    }

    private void Awake()
    {
        if (instance != null)
        {
            DestroyImmediate(this);
            return;
        }

        instance = this;
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        if (youLose)
        {
            countdown = Mathf.Clamp(countdown - Time.deltaTime, 0, 5);
            if (countdown <= 0)
            {
                SceneManager.LoadScene("Menu");
                countdown = 5;
                numeroDaFase = 0;
            }
        }

        else if (youWin && numeroDaFase == 0)
        {
            countdown = Mathf.Clamp(countdown - Time.deltaTime, 0, 5);
            if (countdown <= 0)
            {
                SceneManager.LoadScene("StageTwo");
                countdown = 5;
                numeroDaFase++;
            }
        }

        else if (youWin && numeroDaFase == 1)
        {
            countdown = Mathf.Clamp(countdown - Time.deltaTime, 0, 5);
            if (countdown <= 0)
            {
                SceneManager.LoadScene("StageThree");
                countdown = 5;
                numeroDaFase++;
            }
        }

        else if (youWin && numeroDaFase == 2)
        {
            countdown = Mathf.Clamp(countdown - Time.deltaTime, 0, 5);
            if (countdown <= 0)
            {
                SceneManager.LoadScene("StageFour");
                countdown = 5;
                numeroDaFase++;
            }
        }

        else if (youWin && numeroDaFase == 3)
        {
            countdown = Mathf.Clamp(countdown - Time.deltaTime, 0, 5);
            if (countdown <= 0)
            {
                SceneManager.LoadScene("Menu");
                countdown = 5;
                numeroDaFase = 0;
            }
        }
    }
}
