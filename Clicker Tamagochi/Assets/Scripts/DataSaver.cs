using UnityEngine;
using UnityEngine.UI;

public class DataSaver : MonoBehaviour
{
    [SerializeField] Button saveButton;
    [SerializeField] Button loadButton;

    public Data data;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        data = new Data();
        saveButton.onClick.AddListener(Save);
        loadButton.onClick.AddListener(Load);
    }

    void Save()
    {
        string sdata = JsonUtility.ToJson(data);
        print(sdata);
        PlayerPrefs.SetString("data", sdata);
        
    }

    void Load()
    {
        if (PlayerPrefs.HasKey("data") == false) return;

        string sdata = PlayerPrefs.GetString("data");
        data = JsonUtility.FromJson<Data>(sdata);

        FindObjectOfType<GameManager>().DisplayTexts();
    }

    
}
