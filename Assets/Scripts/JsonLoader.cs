using UnityEngine;
using UnityEngine.UI;

public class JsonLoader : MonoBehaviour
{
    public TextAsset jsonFile;
    public PlayerData playerData;

    void Start()
    {
        LoadJson();
    }

    /// <summary>
    /// Load JSON file and parse it, then display the data on the UI
    /// </summary>
    void LoadJson()
    {
        if (jsonFile != null)
        {
            playerData = JsonUtility.FromJson<PlayerData>(jsonFile.text);
            UIManager.Instance.DisplayPlayerData(playerData);
        }
        else
        {
            Debug.LogError("JSON file not found!");
        }
    }
}
