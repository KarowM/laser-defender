using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Level : MonoBehaviour {

    public void LoadStartMenu() {
        SceneManager.LoadScene(0);
    }

    public void LoadGame() {
        SceneManager.LoadScene("Game");
    }

    public void LoadGameOver() {
        StartCoroutine(WaitAndGameOver());
    }

    IEnumerator WaitAndGameOver() {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Game Over");
    }

    public void QuitGame() {
        Application.Quit();
    }
}