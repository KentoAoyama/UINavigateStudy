using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RectMask2D))]
public class WindowContainer : MonoBehaviour
{
    [Tooltip("‚±‚ÌPageContainer‚Ì–¼‘O")]
    [SerializeField]
    private string _name = "";

    public string GetName()
    {
        return !string.IsNullOrWhiteSpace(_name) ? _name : nameof(gameObject.name);
    }
}
