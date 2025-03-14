using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    public TMP_Text playerNameText;
    public TMP_Text levelText;
    public TMP_Text healthText;
    public TMP_Text positionText;
    public Transform inventoryContainer;
    public GameObject inventoryItemPrefab;

    void Awake()
    {
        Instance = this;
    }

    /// <summary>
    /// Display player data on the UI, including player name, level, health, position, and inventory.
    /// </summary>
    /// <param name="data"></param>

    public void DisplayPlayerData(PlayerData data)
    {
        playerNameText.text = "Name: " + data.record.playerName;
        levelText.text = "Level: " + data.record.level;
        healthText.text = "Health: " + data.record.health;
        positionText.text = $"Position: ({data.record.position.x}, {data.record.position.y}, {data.record.position.z})";

        foreach (Transform child in inventoryContainer)
        {
            Destroy(child.gameObject);
        }

        foreach (var item in data.record.inventory)
        {
            GameObject newItem = Instantiate(inventoryItemPrefab, inventoryContainer);
            newItem.GetComponent<TMP_Text>().text = $"• {item.itemName} x{item.quantity} (Weight: {item.weight})";
        }
    }
}
