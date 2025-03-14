using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class JsonLoader : MonoBehaviour
{
    // The URL of the JSON data to fetch
    private string apiUrl = "https://api.jsonbin.io/v3/b/6686a992e41b4d34e40d06fa";
    public PlayerData playerData;

    void Start()
    {
        StartCoroutine(FetchJsonData());
    }

    /// <summary>
    /// Fetch JSON data from the specified URL and parse it into a PlayerData object.
    /// </summary>
    /// <returns></returns>

    IEnumerator FetchJsonData()
    {
        using (UnityWebRequest request = UnityWebRequest.Get(apiUrl))
        {
            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.Success)
            {
                string json = request.downloadHandler.text;
                playerData = JsonUtility.FromJson<PlayerData>(json);
                UIManager.Instance.DisplayPlayerData(playerData);
            }
            else
            {
                // Log any errors that occur during the request
                Debug.LogError("Error fetching JSON: " + request.error);
            }
        }
    }
}
