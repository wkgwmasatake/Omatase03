using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShutterAudio : MonoBehaviour {

    /*****************************
     * 変数の宣言
    *****************************/
    int AudioFlg = 0;

    public AudioClip ShutterSE;
    AudioSource Aud;
    private GameObject shutter;
    public AnimatorStateInfo animinfo;
    // Use this for initialization
    void Start () {
        this.Aud = GetComponent<AudioSource>();
        this.shutter = GameObject.Find("Shutter");
    }
	
	// Update is called once per frame
	void Update () {
        animinfo = shutter.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0);

        if (animinfo.normalizedTime >= 0.1f && AudioFlg == 0)
        {
            AudioFlg = 1;
            this.Aud.PlayOneShot(this.ShutterSE);
        }
       
	}
}
