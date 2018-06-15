using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Sceneschange : MonoBehaviour
{
        public void change()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Main");
        }
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
