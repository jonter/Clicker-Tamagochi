using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DataSaver : MonoBehaviour
{

    public Data data;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        data = new Data();
        Load();
        StartCoroutine(AutoSave());
    }

    IEnumerator AutoSave()
    {
        while (true)
        {
            yield return new WaitForSecondsRealtime(2);
            string sdata = JsonUtility.ToJson(data);
            print(sdata);
            PlayerPrefs.SetString("data", sdata);
        }
    }

    void Load()
    {
        if (PlayerPrefs.HasKey("data") == false) return;

        string sdata = PlayerPrefs.GetString("data");
        data = JsonUtility.FromJson<Data>(sdata);
    }

    
}
