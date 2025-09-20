using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collectible : MonoBehaviour
{
    public static int AppleCount = 0;
    public static int requiredApples = 12;  
    public AudioClip collectSound;
    public AudioClip SceneTransitionSound;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            AppleCount++;

            if (collectSound != null)
            {
                Debug.Log("Playing sound: " + collectSound.name);
                audioSource.clip = collectSound;
                audioSource.spatialBlend = 0f; // Son 2D pour être sûr qu'il soit entendu
                audioSource.Play();
            }
            AttachToPlayer(other.transform);
            if(AppleCount >= requiredApples)
            {
                AppleCount = 0;
                if (SceneTransitionSound != null)
                {
                    Debug.Log("Playing sound: " + SceneTransitionSound.name);
                    audioSource.clip = SceneTransitionSound;
                    audioSource.spatialBlend = 0f; // Son 2D pour être sûr qu'il soit entendu
                    audioSource.Play();
                    Invoke(nameof(LoadScene), SceneTransitionSound.length);
                }
                else
                {
                    LoadScene();
                }
            }
        }
    }
    private void AttachToPlayer(Transform player)
    { //suggerée par l’IA
        transform.SetParent(player);
        transform.localPosition = new Vector3(0, 0.7f, 0); //ajustez la position selon votre scène
        transform.localRotation = Quaternion.identity;
    }

    private void LoadScene()
    {
        SceneManager.LoadScene("Assets/Scenes/MyFirstScene.unity", LoadSceneMode.Single);
    }
}