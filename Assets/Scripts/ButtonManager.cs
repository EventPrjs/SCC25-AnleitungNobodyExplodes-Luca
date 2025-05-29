using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public Button[] buttons;        // per Inspector zuweisen
    public Color[] colors;          // Farben im Inspector einstellen
    private int[] currentColorIndex;

    void Start()
    {
        currentColorIndex = new int[buttons.Length];

        // Startfarben setzen
        for (int i = 0; i < buttons.Length; i++)
        {
            SetButtonColor(i, 0);
        }
    }

    public void OnButtonClick(int index)
    {
        currentColorIndex[index]++;

        if (currentColorIndex[index] >= colors.Length)
            currentColorIndex[index] = 0;

        SetButtonColor(index, currentColorIndex[index]);
    }

    void SetButtonColor(int buttonIndex, int colorIndex)
    {
        buttons[buttonIndex].targetGraphic.color = colors[colorIndex];
    }
}
