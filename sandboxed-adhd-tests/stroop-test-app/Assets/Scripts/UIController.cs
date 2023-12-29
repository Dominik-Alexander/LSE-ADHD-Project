using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;

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

        StartCoroutine(ChangeColorAndTextRoutine());
    }

    IEnumerator ChangeColorAndTextRoutine()
    {
        while (true)
        {
            // Change color and text logic
            ChangeColor(Random.Range(1, 5));
            ChangeText(Random.Range(1, 5));

            lbColorWord.text = colorWordText.ToString();

            switch (colorWordColor)
            {
                case 0:
                    lbColorWord.style.color = Color.white;
                    break;
                case (ColorWordColor)1:
                    lbColorWord.style.color = Color.green;
                    break;
                case (ColorWordColor)2:
                    lbColorWord.style.color = Color.red;
                    break;
                case (ColorWordColor)3:
                    lbColorWord.style.color = Color.blue;
                    break;
                case (ColorWordColor)4:
                    lbColorWord.style.color = Color.yellow;
                    break;
            }

            yield return new WaitForSeconds(2.0f);

            lbColorWord.style.color = Color.white;
            lbColorWord.text = ".";

            yield return new WaitForSeconds(0.75f);
        }
    }

    private void ChangeColor(int colorNr)
    {
        colorWordColor = (ColorWordColor)colorNr;
    }


    private void ChangeText(int textNr)
    {
        colorWordText = (ColorWordText)textNr;
    }
}
