﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zycie : MonoBehaviour
{
    static public int zycie = 3;
    public GameObject kon;
    public int mozKon = 1;

    // Start is called before the first frame update
    void Start()
    {
        zycie = PlayerPrefs.GetInt("ILZY");
        this.GetComponent<MeshRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<TextMesh>().text = zycie.ToString();

        PlayerPrefs.SetInt("ILZY", zycie);
        
        if (zycie < 1)
        {
            kon.SetActive(true);
            Cursor.visible = true;
            Time.timeScale = 0.0f;
            mozKon = 0;
            PlayerPrefs.SetInt("MozKon", mozKon);

        }
        else
        {
            mozKon = 1;
            PlayerPrefs.SetInt("MozKon", mozKon);
        }
    }
}
