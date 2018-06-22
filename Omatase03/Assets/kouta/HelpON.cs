using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelpON : MonoBehaviour {

    /*********************************************
     * 変数の宣言
    ***********************************************/
    public int HelpFlg = 0;

    public AudioClip ChoiceSE;
    AudioSource Aud;

    //Use this for initialization
      void Start () {
        this.Aud = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    //void Update () {

    //}

    public void HelpONDown()
    {
        HelpFlg = 1;
        Debug.Log(HelpFlg);

        this.Aud.PlayOneShot(this.ChoiceSE);
    }

    public void HelpOFFDown()
    {
        HelpFlg = 0;
        Debug.Log(HelpFlg);

        this.Aud.PlayOneShot(this.ChoiceSE);
    }
}
