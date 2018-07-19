using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBox : MonoBehaviour
{
    public Text textInBox;

    public void InputText(Text Letter)
    {
        if (textInBox.text == "Name")
        {
            textInBox.text = "";
            textInBox.text += Letter.text;
        }
        else
        {
            textInBox.text += Letter.text;
        }
    }
}

