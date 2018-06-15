using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sceneschange : MonoBehaviour
{
        public void change()
    {
        SceneManager.LoadScene("GameMain_Scene");
        /*
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("GameMain_Scene");
        }
        */
    }
       
// Use this for initialization
void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
