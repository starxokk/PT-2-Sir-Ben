
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script1 : MonoBehaviour
{
    public InputField inputField;
    public InputField inputField2;
    public Text resultText;

    public void CompareNumbers()
    {
        if (float.TryParse(inputField.text, out float number1)
        && float.TryParse(inputField2.text, out float number2))
        {
            if (number1 > number2)
            {
                resultText.text = "1st Number is Greater!";
            }
            else if (number1 < number2)
            {
                resultText.text = "2nd Number is Greater!";
            }
            else
            {
                resultText.text = "Both are equal";
            }
        }

    }
}
