﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainScene : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartGames()
    {
        Slingshot.isFire = GameObject.Find("check_first").GetComponent<Toggle>().isOn;
        if (!Slingshot.isFire)
        {
            Slingshot.firstName = GameObject.Find("txt_first").GetComponent<InputField>().text;
            Slingshot.secondName = GameObject.Find("txt_second").GetComponent<InputField>().text;
        }
        else
        {
            Slingshot.firstName = GameObject.Find("txt_second").GetComponent<InputField>().text;
            Slingshot.secondName = GameObject.Find("txt_first").GetComponent<InputField>().text;
        }
        SceneManager.LoadScene("_Scene_0");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
