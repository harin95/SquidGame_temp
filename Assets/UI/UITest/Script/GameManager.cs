using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;




public enum GameState {
    menu,
    inGame,
    gameOver
}
public class GameManager : MonoBehaviour
{

    // 버튼을 왜 못가져 오지?

    public static GameManager instance;
    public TextMeshProUGUI gameOverText;
    // public Button restartButton;
    public GameState currentGameState = GameState.menu;




    void Awake()
    {
        instance = this;

    }
    // Start is called before the first frame update
    void Start()
    {
        gameOverText.gameObject.SetActive(false);
        //StartGame();
        currentGameState = GameState.menu;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("s"))
        {
            StartGame();
        }

        if (Input.GetButtonDown("e"))
        {
            GameOver();
        }
    }

    public void StartGame()
    {
        SetGameState(GameState.inGame);

    }

    public void GameOver()
    {
        SetGameState(GameState.gameOver);
        gameOverText.gameObject.SetActive(true);
        //restartButton.gameObject.SetActive(true);
    }

    public void BackToMenu()
    {

    }

    void SetGameState(GameState newGameState)
    {
        if (newGameState == GameState.menu)
        { }
        else if (newGameState == GameState.inGame)
        { }
        else if (newGameState == GameState.gameOver)
        { }

        currentGameState = newGameState;

    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
