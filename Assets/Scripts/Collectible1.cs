using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Collectible1 : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene("Assets/Scenes/MySecondScene.unity", LoadSceneMode.Single);


        }
    }
}