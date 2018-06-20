using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleAudio : MonoBehaviour {
    /*****************************
     * 変数の宣言
    *****************************/

    int TitleFlg = 0;
    public AudioClip TitleBGM;
    AudioSource Aud;

    // Use this for initialization
    void Start () {
        this.Aud = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
        if(TitleFlg == 0)
        {
            this.Aud.PlayOneShot(this.TitleBGM);
            TitleFlg = 1;
        }

    }
}
