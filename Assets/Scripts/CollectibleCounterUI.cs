// 20/09/2025 AI-Tag
// This was created with the help of Assistant, a Unity Artificial Intelligence product.

using TMPro; // Import TextMeshPro namespace
using UnityEngine;

public class CollectibleCounterUI : MonoBehaviour
{
    public TextMeshProUGUI collectibleText; // Reference to the TextMeshProUGUI component

    private int requiredCatBots = Collectible1.requiredCatBots;

    void Update()
    {
        // Update the text to show the collected and required CatBots
        collectibleText.text = $"Collected: {Collectible.AppleCount} / {Collectible.requiredApples}";
    }
}