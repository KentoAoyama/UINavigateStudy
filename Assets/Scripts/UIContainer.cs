using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIContainer : MonoBehaviour
{
    private Dictionary<string, PageContainer> _pageContainerDic = new();

    private Dictionary<string, WindowContainer> _windowContainerDic = new();

    private void Awake()
    {
        var pageContainers = FindObjectsByType<PageContainer>(FindObjectsSortMode.None);
        foreach (var container in pageContainers)
        {
            _pageContainerDic.Add(container.GetName(), container);
        }
        var windowContainers = FindObjectsByType<WindowContainer>(FindObjectsSortMode.None);
        foreach (var container in windowContainers)
        {
            _windowContainerDic.Add(container.GetName(), container);
        }
    }
}
