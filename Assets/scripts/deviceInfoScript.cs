using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class deviceInfoScript : MonoBehaviour
{
    int avgFrameRate;
    Text display_Text;

    private void Start()
    {

        display_Text = GetComponent<Text>();
    }

    public void FixedUpdate()
    {
        float current = 0;
        current = Time.frameCount / Time.time;
        avgFrameRate = (int)current;
        display_Text.text = " FPS: " + avgFrameRate.ToString() + "\n" + "Operating System:\n" + SystemInfo.operatingSystem.ToString() + "\n" + "Device Model: " + SystemInfo.deviceModel.ToString();
    }
}
