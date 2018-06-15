using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class scoreUI : MonoBehaviour
{
    public Text ScoreUI;
    public Text FirstscoreUI;
    public Text SecondscoreUI;
    public Text ThirdscoreUI;
    public static int Score;
    static string str;
    public InputField inputField;
    public Text text;
    private int[] Topscore = new int[3];
    private string[] Topname = new string[3];
    //public SaveScript save;

    // Use this for initialization
    void Start()
    {

        string a = SceneManager.GetActiveScene().name;
        if(a == "result"){
        Score = sample2.getA();
        str = SaveScript.getB();
        }

        GetPrefs();

        SetDefaultData();
    }


    // Update is called once per frame
    void Update()
    {
 
        if (Topscore[0] < Score)
            Topscore[0] = Score;
            //Topname[0] = str;

        if (Topscore[1] < Score && Topscore[0] > Score)
            Topscore[1] = Score;
            //Topname[1] = str;

        if (Topscore[2] < Score && Topscore[1] > Score)
            Topscore[2] = Score;
            //str = Topname[2];

        
        ScoreUI.text = Score.WithComma() + "円！！";
        FirstscoreUI.text = "1位: " + Topname[0] + " " + Topscore[0].WithComma() + "円";
        SecondscoreUI.text = "2位: " + Topname[1] + " " + Topscore[1].WithComma() + "円";
        ThirdscoreUI.text = "3位: " + Topname[2] + " " + Topscore[2].WithComma() + "円";

        KeyEntryCheck();
    }

    public void Save()
    {
        //呼び出し時のキーと値をセットする
        PlayerPrefs.SetInt("1stscoreKey", Topscore[0]);
        PlayerPrefs.SetInt("2ndscoreKey", Topscore[1]);
        PlayerPrefs.SetInt("3rdscoreKey", Topscore[2]);
        //呼び出し時のキーと名前をセットする
        PlayerPrefs.SetString("1stnameKey", Topname[0]);
        PlayerPrefs.SetString("2ndnameKey", Topname[1]);
        PlayerPrefs.SetString("3rdnameKey", Topname[2]);
        //キーと値を保存
        PlayerPrefs.Save();
        Debug.Log("Saved.");
    }

    public void Reset()
    {
        //キーを全部消す
        PlayerPrefs.DeleteAll();
        Debug.Log("Deleted.");
    }


    void KeyEntryCheck()
    {
       // if (Input.GetKeyDown(KeyCode.S) == true) Save();
       // if (Input.GetKeyDown(KeyCode.D) == true) Reset();
    }

    void GetPrefs()
    {
        //キーを使用して値を取得
        Topscore[0] = PlayerPrefs.GetInt("1stscoreKey");
        Topscore[1] = PlayerPrefs.GetInt("2ndscoreKey");
        Topscore[2] = PlayerPrefs.GetInt("3rdscoreKey");
        //キーを使用して名前を取得
        Topname[0] = PlayerPrefs.GetString("1stnameKey");
        Topname[1] = PlayerPrefs.GetString("2ndnameKey");
        Topname[2] = PlayerPrefs.GetString("3rdnameKey");
    }

    void SetDefaultData()
    {
        if (Topscore[0] == Topscore[1] && Topscore[1] == Topscore[2] && Topscore[0] == 0)
        {
            Topscore[0] = 1000;
            Topscore[1] = 500;
            Save();
            Debug.Log("EntrySave");
        }
        if (Topname[0] == Topname[1] && Topname[1] == Topname[2] && Topname[0] == "")
        {
            Topname[0] = "AAA";
            Topname[1] = "BBB";
            Topname[2] = "CCC";
            Save();
            Debug.Log("EntrySave");
        }
    }


}
