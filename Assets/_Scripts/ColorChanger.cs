using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ColorChanger : MonoBehaviour
{
    public Color[] colors;
    private TextMeshPro Title;
    private string label = "A Ball Can't Dance";
    int currentInd = 0;

    private void Awake()
    {
        Title = gameObject.GetComponent<TextMeshPro>() ?? gameObject.AddComponent<TextMeshPro>();

        Title.text = label;
        Title.faceColor = Color.cyan;
    }
    private void Start()
    {
        colors[0] = Color.blue;
        colors[1] = Color.magenta;
        colors[2] = Color.red;
        colors[3] = Color.yellow;
        colors[4] = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
       Title.faceColor = colors[Mathf.FloorToInt(currentInd / 20) % colors.Length];
        currentInd++;

    }
}
