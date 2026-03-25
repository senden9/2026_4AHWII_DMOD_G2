using TMPro;
using UnityEngine;

public class UiCounterExample : MonoBehaviour
{
    public TextMeshProUGUI textCounter;
    private int counter = 0;
    private bool reversed = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (reversed)
        {
            counter--;
        } else
        {
            counter++;
        }
        textCounter.text = $"Counter: {counter}";
    }

    public void ResetCounter()
    {
        counter = 0;
    }

    public void ReverseButton()
    {
        reversed ^= true;
    }
}
