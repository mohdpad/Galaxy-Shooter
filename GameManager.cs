using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;         //library for using scene manager

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private bool _isGameOver;           //boolean question

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.R) && _isGameOver==true)
        {
            SceneManager.LoadScene(1);             //current game scene
        }
    }
    
    public void GameOver()
    {
        _isGameOver = true;
    }
}
