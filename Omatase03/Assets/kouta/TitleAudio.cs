using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleAudio : MonoBehaviour {
    /*****************************
     * 変数の宣言
    *****************************/

    
    AudioSource Aud;

    // Use this for initialization
    void Start () {
        this.Aud = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
           

    }
    public void AudioStop()
    {
        Aud.Stop();
    }
}
