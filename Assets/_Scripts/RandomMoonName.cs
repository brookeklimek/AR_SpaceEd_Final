﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Lean.Touch;

public class RandomMoonName : MonoBehaviour {

    public Text moonPhase;
    public string[] phases;
    public static bool correct;
    public static string phase;

    void Start() {
        correct = true;
    }

    void Update() {
        phase = moonPhase.text;
        if (correct) {
            Game();
            correct = false;
        }
    }

    public void Clicked() {

        Debug.Log("My name is " + gameObject.name);
        moonPhase.text = "" + gameObject.name;
    }

    private void Game() {

        System.Random random = new System.Random();
        moonPhase.text = "" + phases[random.Next(phases.Length)];
        


    }


}