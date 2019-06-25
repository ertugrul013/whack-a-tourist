using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UIController : MonoBehaviour
{
    public UIController instance;

    [SerializeField] private TextMeshProUGUI _score;
    private int currentScore;

    [SerializeField] private TextMeshProUGUI _cocosLeft;

    private bool isPaused;

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this);
        }
    }

    public void AmountOfCoco(bool isReset = false)
    {
        //if(isReset) //playercontroller.instance.cocos = 5;
        _cocosLeft.SetText("X {0}", 0);
    }

    public void score(int scoreToAdd)
    {
        currentScore = +scoreToAdd;
        _score.SetText("Score {0}", currentScore);

    }

    public void Pause()
    {
        if (isPaused) Time.timeScale = 0;
        else if (!isPaused) Time.timeScale = 0;

        isPaused = !isPaused;
    }

    public void loadLevel(int index) => SceneManager.LoadScene(index);

}
