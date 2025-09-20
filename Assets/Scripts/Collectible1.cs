// 20/09/2025 AI-Tag
// This was created with the help of Assistant, a Unity Artificial Intelligence product.
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collectible1 : MonoBehaviour
{
    public static int catBotCount = 0;
    public static int requiredCatBots = 5;
    public AudioClip collectSound;
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
            catBotCount++;

            if (collectSound != null)
            {
                Debug.Log("Playing sound: " + collectSound.name);
                audioSource.clip = collectSound;
                audioSource.spatialBlend = 0f; // Son 2D pour �tre s�r qu'il soit entendu
                audioSource.Play();
            }

            // D�sactive le Renderer si pr�sent
            var renderer = GetComponent<Renderer>();
            if (renderer != null)
            {
                renderer.enabled = false;
            }

            // D�sactive le Collider si pr�sent
            var collider = GetComponent<Collider>();
            if (collider != null)
            {
                collider.enabled = false;
            }
            // D�truire l'objet apr�s la dur�e du son
            Destroy(gameObject, collectSound != null ? collectSound.length : 0f);

            if (catBotCount >= requiredCatBots)
            {
                catBotCount = 0;
                SceneManager.LoadScene("Assets/Scenes/MySecondScene.unity", LoadSceneMode.Single);
            }
        }
    }
}