using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    [SerializeField]
    Button _button;

    [SerializeField]
    Color _targetColor;

    private Color _originalColor;


    void Start()
    {
        _originalColor = _button.GetComponentInChildren<Text>().color;
    }

    public void ChangeColorOnHover()
    {
        Debug.Log("Hovering over button");
        _button.GetComponentInChildren<Text>().color = _targetColor;

    }

    public void ChangeColorOnLeave()
    {
        Debug.Log("Leaving button");
        _button.GetComponentInChildren<Text>().color = _originalColor;
    }


}
