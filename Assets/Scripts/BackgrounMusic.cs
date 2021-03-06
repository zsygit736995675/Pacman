﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgrounMusic : MonoBehaviour {
    public static int m_audioSize;
    private AudioSource m_audioSource;
	// Use this for initialization
	void Start () {
        GameObject[] bm =  GameObject.FindGameObjectsWithTag("BackgroundMusic");
        if (bm.Length > 1)
        {
            Destroy(gameObject);
        }
        if (bm.Length == 1)
        {
            DontDestroyOnLoad(gameObject);
        }
        if (PlayerPrefs.HasKey("AudioSize"))
        {
            m_audioSize = PlayerPrefs.GetInt("AudioSize");
        }
        else
        {
            m_audioSize = 100;
        }
        m_audioSource = GetComponent<AudioSource>();
        m_audioSource.volume = m_audioSize / 100f;
    
	}
	
	// Update is called once per frame
	void Update () {
        m_audioSource.volume = m_audioSize / 100f;
	}
}
