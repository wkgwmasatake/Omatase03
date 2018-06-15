using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static partial class ObjectExtensions
{
    /// <summary>
    /// 渡された数値を3桁カンマ区切りの文字列に変換して返します
    /// </summary>
    public static string WithComma(this object self)
    {
        return string.Format("{0:#,##0}", self);
    }
}

public class sample2 : MonoBehaviour {
    public Text ScoreUI;
    public static int Score;

	// Use this for initialization
	void Start () {
        Score = 0;
        
	}
	
	// Update is called once per frame
	void Update () {
        ScoreUI.text = "Score: " + Score.WithComma();
        KeyEntryCheck();
	}

    void Addscore(int a)
    {
        //スコア加算
        Score += a;
    }
    void KeyEntryCheck()
    {
        if (Input.GetKeyDown(KeyCode.Z) == true) Addscore(50);
        if (Input.GetKeyDown(KeyCode.X) == true) Addscore(-50);
    }

    public static int getA()
    {
        return Score;
    }
}
