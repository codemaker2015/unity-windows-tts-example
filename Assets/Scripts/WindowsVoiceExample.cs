using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WindowsVoiceExample : MonoBehaviour
{
    [SerializeField] InputField inputField;
    public void Run()
    {
        WindowsVoice.speak(inputField.text);
    }
}
