using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIEtCompagnie : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("Scheme 2");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")) SceneManager.LoadScene("Menu");
    }
}
