using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoad : MonoBehaviour
{
    
    void Start()
    {
        int num = PlayerPrefs.GetInt("mynum");// load
        Debug.Log(num);
        PlayerPrefs.SetInt("mynum", 10);//save
        PlayerPrefs.Save();
        // easy save
        int num2 =ES3.Load("wheelIndex",0);
        Debug.Log(num2);
        ES3.Save<int>("wheelIndex", 123);
    }

    public void CreateSpreadsheet()
    {
        ES3Spreadsheet sheet = new ES3Spreadsheet();
        ES3Settings settings = new ES3Settings();
        settings.encryptionType = ES3.EncryptionType.None;  //if want to not save with encryption        

        // Add data to cells in the spreadsheet.
        for (int col = 0; col < 10; col++)
            for (int row = 0; row < 8; row++)
                sheet.SetCell<string>(col, row, "someData");

        sheet.Save("mySheet.csv", settings);
    }

    public void SaveBtn(int score, int health)
    {
        PlayerPrefs.SetInt("score", score);
        PlayerPrefs.SetInt("health", health);
    }

    public void LoadBtn(int score, int health)
    {
        PlayerPrefs.GetInt("score", score);
        PlayerPrefs.GetInt("health", health);
    }
}
