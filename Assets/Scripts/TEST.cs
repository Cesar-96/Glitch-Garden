﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEST : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
		print (PlayerPrefsManager.GetMasterVolume());
		PlayerPrefsManager.SetMasterVolume(10);
		print (PlayerPrefsManager.GetMasterVolume());

		print(PlayerPrefsManager.IsLevelUnlocked(2));
		PlayerPrefsManager.UnlockLevel(2);
		print(PlayerPrefsManager.IsLevelUnlocked(2));
		 
		print(PlayerPrefsManager.GetDifficulty ());
		PlayerPrefsManager.SetDifficulty(12f);
		print(PlayerPrefsManager.GetDifficulty ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
