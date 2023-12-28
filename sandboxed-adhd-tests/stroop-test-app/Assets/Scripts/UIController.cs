using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Random = System.Random;

public class UIController : MonoBehaviour
{
    VisualElement root;

    VisualElement veLabelContainer;
    Label lbColorWord;

    VisualElement veButtonContainer;
    Button btGreen;
    Button btRed;
    Button btBlue;
    Button btYellow;

    enum ColorWordColor {
        WHITE,
        GREEN,
        RED,
        BLUE,
        YELLOW
    };

    enum ColorWordText
    {
        DOT,
        GREEN,
        RED,
        BLUE,
        YELLOW
    };

    ColorWordColor colorWordColor;
    ColorWordText colorWordText;

    // Start is called before the first frame update
    void Start()
    {
        colorWordColor = ColorWordColor.WHITE;
        colorWordText = ColorWordText.DOT;

        root = GetComponent<UIDocument>().rootVisualElement;

        veLabelContainer = root.Q<VisualElement>("VELabelContainer");
        lbColorWord = veLabelContainer.Q<Label>("LbColorWord");

        veButtonContainer = root.Q<VisualElement>("VEButtonContainer");
        btGreen = veButtonContainer.Q<Button>("BtGreen");
        btRed = veButtonContainer.Q<Button>("BtRed");
        btBlue = veButtonContainer.Q<Button>("BtBlue");
        btYellow = veButtonContainer.Q<Button>("BtYellow");
    }

    // Update is called once per frame
    void Update()
    {
        Random randomizer = new Random();

        ChangeColor(randomizer.Next(1, 5));
        ChangeText(randomizer.Next(1, 5));

        lbColorWord.text = colorWordText.ToString();

        switch(colorWordColor)
        {
            case 0:
                lbColorWord.style.color = new Color(255, 255, 255);
                break;
            case (ColorWordColor) 1:
                lbColorWord.style.color = new Color(0, 255, 0);
                break;
            case (ColorWordColor) 2:
                lbColorWord.style.color = new Color(255, 0, 0);
                break;
            case (ColorWordColor) 3:
                lbColorWord.style.color = new Color(0, 0, 255);
                break;
            case (ColorWordColor) 4:
                lbColorWord.style.color = new Color(255, 255, 0);
                break;
        }

    }

    private void ChangeColor(int colorNr)
    {
        this.colorWordColor = (ColorWordColor)colorNr;
    }


    private void ChangeText(int textNr)
    {
        this.colorWordText = (ColorWordText)textNr;
    }
}
