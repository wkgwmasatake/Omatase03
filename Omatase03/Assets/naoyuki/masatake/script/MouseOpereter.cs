﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseOpereter : MonoBehaviour
{
    private Vector3 screenPoint;
    private Vector3 offset;

    ObjectCount CursorLock;

    AudioSource [] FoodSE;//GetComponentするための変数
    AudioSource FoodDropSE;//食材をミキサー以外のところで離したときのSE
    AudioSource FoodGrabSE;//食材をつかんだ時のSE

    void OnMouseDown()
    {
        //カメラから見たオブジェクトの現在位置を画面位置座標に変換
        screenPoint = Camera.main.WorldToScreenPoint(transform.position);

        //取得したscreenpointの値を変数に格納
        float posx = Input.mousePosition.x;
        float posy = Input.mousePosition.y;

        if (CursorLock.CursorLock)
        {
            FoodGrabSE.PlayOneShot(FoodGrabSE.clip);
        }

        offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(posx, posy, 0));
    }

    void OnMouseDrag()
    {
        if (!CursorLock.CursorLock)
        {
            //CursorLockがfalseなら以後の処理をしない
            return;
        }

        //ドラッグ時のマウス位置をシーン上の座標に変換
        float posx = Input.mousePosition.x;
        float posy = Input.mousePosition.y;

        //Debug.Log(posx.ToString() + " - " + posy.ToString());

        Vector3 currentScreenPoint = new Vector3(posx, posy, 0);

        Vector3 currentPosition = Camera.main.ScreenToWorldPoint(currentScreenPoint) + offset;

        transform.position = currentPosition;
    }

    private void OnMouseUp()
    {
        if(CursorLock.CursorLock && CursorLock.ReturnPlayerFlg() == 99)
        {
            FoodDropSE.PlayOneShot(FoodDropSE.clip);
        }
    }

    //Use this for initialization
    void Start()
    {
        Input.multiTouchEnabled = false;//マルチタッチを無効化
        this.CursorLock = GameObject.Find("Mixer").GetComponent<ObjectCount>();//ObjectCountスクリプトを取得
        this.FoodSE = GetComponents<AudioSource>();
        this.FoodDropSE = FoodSE[0];
        this.FoodGrabSE = FoodSE[1];
    }

    //// Update is called once per frame
    //void Update () {

    //}
}
