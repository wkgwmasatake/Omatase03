using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;     //UIを使用可能にする

public class Credit : MonoBehaviour {
    /*****************************
    * 変数の宣言
   *****************************/

    int CreditFlg = 1;

    private GameObject CreditImage;
    private float red, green, blue;    //RGBを操作するための変数

    public AudioClip ChoiceSE;
    AudioSource Aud;

    // Use this for initialization
    void Start () {

        this.CreditImage = GameObject.Find("CreditImage");
        this.red = this.CreditImage.GetComponent<Image>().color.r;
        this.green = this.CreditImage.GetComponent<Image>().color.g;
        this.blue = this.CreditImage.GetComponent<Image>().color.b;

        this.CreditImage.SetActive(false);

        this.Aud = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {

    }
    public void CreditDown()
    {
        this.Aud.PlayOneShot(this.ChoiceSE);

        if(CreditFlg == 0)
        {
            this.CreditImage.SetActive(false);
            CreditFlg = 1;
        } else if(CreditFlg == 1)
        {
            this.CreditImage.SetActive(true);
            CreditFlg = 0;
        }
    }
}
