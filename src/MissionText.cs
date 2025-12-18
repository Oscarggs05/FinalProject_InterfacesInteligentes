using UnityEngine;
using TMPro;

public class MisionText : MonoBehaviour
{
    public TextMeshProUGUI instructionText;
    public string[] instructions;
    public float changeTime = 5f;

    private int currentIndex = 0;

    void Start()
    {
        instructionText.text = instructions[currentIndex];
        InvokeRepeating(nameof(ChangeText), changeTime, changeTime);
    }

    void ChangeText()
    {
        currentIndex = (currentIndex + 1) % instructions.Length;
        instructionText.text = instructions[currentIndex];
    }
}
