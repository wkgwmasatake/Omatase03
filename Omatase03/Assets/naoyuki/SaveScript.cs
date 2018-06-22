using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public  class SaveScript : MonoBehaviour{

    static string str;
    public InputField inputField;
    public Text text;

    public void SaveText(string txt)
    {
        //str = inputField.text;
        //text.text = str;
        str = txt;
        inputField.text = "";
        //Debug.Log("nameimput");
        
    }

    //void Start()
    //{

    //}

    //void  Update(){

    //}

    public static string getB()
    {
        return str;
    }

}