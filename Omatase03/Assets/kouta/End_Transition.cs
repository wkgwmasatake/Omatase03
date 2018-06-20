using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End_Transition : MonoBehaviour {

    /*********************************************
     * 変数の宣言
    ***********************************************/

    private Animator ShutterAnim;
    private GameObject Shutter;

    public AudioClip ChoiceSE;
    AudioSource Aud;

    // Use this for initialization
    void Start () {
        this.Shutter = GameObject.Find("Shutter");
        ShutterAnim = Shutter.GetComponent<Animator>();

        this.Aud = GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void Update () {
        
    }

    public void EndDown () {
        Invoke("SceneTransition", 1.2f);
        ShutterAnim.SetBool("NextShutter", true);

        this.Aud.PlayOneShot(this.ChoiceSE);


    }
    public void SceneTransition()
    {
        SceneManager.LoadScene("End_Scene");
    }
}
