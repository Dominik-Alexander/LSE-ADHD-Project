using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UIController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;

        VisualElement veLabelContainer = root.Q<VisualElement>("VELabelContainer");
        Label lbColorWord = veLabelContainer.Q<Label>("LbColorWord");

        VisualElement veButtonContainer = root.Q<VisualElement>("VEButtonContainer");
        Button btGreen = veButtonContainer.Q<Button>("BtGreen");
        Button btRed = veButtonContainer.Q<Button>("BtRed");
        Button btBlue = veButtonContainer.Q<Button>("BtBlue");
        Button btYellow = veButtonContainer.Q<Button>("BtYellow");
    }
}
