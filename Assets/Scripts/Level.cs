﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour {

    public void LoadStartMenu() {
        SceneManager.LoadScene(0);
    }

    public void LoadGame() {
        SceneManager.LoadScene("Game");
    }

    public void LoadGameOver() {
        SceneManager.LoadScene("GameOver");
    }

    public void QuitGame() {
        Application.Quit();
    }
}