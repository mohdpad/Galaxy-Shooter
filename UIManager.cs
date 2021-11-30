using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    [SerializeField]
    private Text _scoreText;
    [SerializeField]
    private Image _LivesImg;                  //displays lives
    [SerializeField]
    private Sprite[] _liveSprites;              //displays lives 
    [SerializeField]
    private Text _gameOverText;                 //game over text after lives = 0
    [SerializeField]
    private Text _restartText;
    private GameManager _gameManager;


    // Start is called before the first frame update
    void Start()
    {
        _scoreText.text = "Score " + 0;
        _gameOverText.gameObject.SetActive(false);
        _gameManager = GameObject.Find("Game_Manager").GetComponent<GameManager>();

        if(_gameManager == null)
        {
            Debug.LogError("GameManager is NULL");
        }
    }

    public void UpdateScore(int playerScore)               //displays score on the screen
    {
        _scoreText.text = "Score " + playerScore;
    }

    public void UpdateLives(int currentLives)                         //updates lives 
    {
        _LivesImg.sprite = _liveSprites[currentLives];
        
        if(currentLives == 0)
        {
            GameOverSequence();
        }
    }

    void GameOverSequence()
    {
        _gameManager.GameOver();
        _gameOverText.gameObject.SetActive(true);
        _restartText.gameObject.SetActive(true);
        StartCoroutine(GameOverFlikerRoutine());
    }


    IEnumerator GameOverFlikerRoutine()                       //game over blinks on screen
    {
        _gameOverText.text = "GAME OVER";
        yield return new WaitForSeconds(0.5f);
        _gameOverText.text = "";
        yield return new WaitForSeconds(0.5f);
    }
}
