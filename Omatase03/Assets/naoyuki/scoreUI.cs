using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class scoreUI : MonoBehaviour
{
    public Text ScoreUI;
    public Text FirstrankUI;
    public Text SecondrankUI;
    public Text ThirdrankUI;

    public Text FirstnameUI;
    public Text SecondnameUI;
    public Text ThirdnameUI;

    public Text FirstscoreUI;
    public Text SecondscoreUI;
    public Text ThirdscoreUI;

    public static int TotalAmount;
    static string str;
    public InputField inputField;
    public Text text;
    string RankStr;
    private int[] Toprank = new int[3];
    private string[] Topname = new string[3];
    private int[] Topscore = new int[3];
    public static int Rank;

    string a;
    //public SaveScript save;

    // Use this for initialization
    void Start()
    {
        string a = SceneManager.GetActiveScene().name;
        if(a == "result"){
            TotalAmount = ObjectCount.getA();
            Debug.Log("TotalAmount = " + TotalAmount);
            str = SaveScript.getB();
        }

        GetPrefs();

        SetDefaultData();

        if (a == "result")
        {
            if (Topscore[0] < TotalAmount)
            {
                Debug.Log("1st");
                //スコア上書き
                Topscore[2] = Topscore[1];
                Topscore[1] = Topscore[0];
                Topscore[0] = TotalAmount;

                //名前上書き
                Topname[2] = Topname[1];
                Topname[1] = Topname[0];
                Topname[0] = "";

                Rank = 0;
            }
            else if (Topscore[1] < TotalAmount && Topscore[0] >= TotalAmount)
            {
                Debug.Log("2nd");
                //スコア上書き
                Topscore[2] = Topscore[1];
                Topscore[1] = TotalAmount;

                //名前上書き
                Topname[2] = Topname[1];
                Topname[1] = "";

                Rank = 1;
            }
            else if (Topscore[2] < TotalAmount && Topscore[1] >= TotalAmount)// 3位
            {
                Debug.Log("3rd");
                //スコア上書き
                Topscore[2] = TotalAmount;

                //名前上書き
                Topname[2] = "";

                Rank = 2;
            }
            else if (Topscore[2] >= TotalAmount)
            {
                SceneManager.LoadScene("Ranking");
                Debug.Log(Topscore[2]);
                Debug.Log(TotalAmount);
                Debug.Log("Scena_change");

                //Rank = 3;
            }
        }
    }


    // Update is called once per frame
    void Update()
    {

<<<<<<< HEAD
            ScoreUI.text = TotalAmount.WithComma();
=======
        if (Topscore[0] < TotalAmount)
            Topscore[0] = TotalAmount;
            //Topname[0] = str;

        if (Topscore[1] < TotalAmount && Topscore[0] > TotalAmount)
            //Topscore[2] = Topscore[1];
            Topscore[1] = TotalAmount;
            //Topname[1] = str;

        if (Topscore[2] < TotalAmount && Topscore[1] > TotalAmount)
            Topscore[2] = TotalAmount;
            //str = Topname[2];

        if (Topscore[2] > TotalAmount)
            SceneManager.LoadScene("Ranking");


        ScoreUI.text = TotalAmount.WithComma();
>>>>>>> ce79fbd8f368a78c37a02d6455567b419d43e23d

            FirstrankUI.text = "1st";
            SecondrankUI.text = "2rd";
            ThirdrankUI.text = "3rd";

            FirstnameUI.text = Topname[0];
            SecondnameUI.text = Topname[1];
            ThirdnameUI.text = Topname[2];

            FirstscoreUI.text = Topscore[0].WithComma();
            SecondscoreUI.text = Topscore[1].WithComma();
            ThirdscoreUI.text = Topscore[2].WithComma();

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
        if (Input.GetKeyDown(KeyCode.S) == true) Save();
        if (Input.GetKeyDown(KeyCode.D) == true) Reset();
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
            Topscore[1] = 750;
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

    public void NameUpdate(int rank, string name)
    {
        Topname[rank] = name;
        Save();
        Debug.Log("NameUpdate");
    }

    public void Getstring(string str)
    {
        Debug.Log(str);
        NameUpdate(Rank, str);
    }


}
