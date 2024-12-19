using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider changeScene)
    {
        if (changeScene.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(2);
        }
    }
}
