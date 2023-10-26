using System;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class IntDataText : MonoBehaviour
{
    public Text label;
    public IntData dataobj;

    private void Start()
    {
        label = GetComponent<Text>();
        UpdateLabel();
    }

    public void UpdateLabel()
    {
        label.text = dataobj.Value.ToString(CultureInfo.InvariantCulture);
    }
}