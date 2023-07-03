using Cysharp.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Window : MonoBehaviour, IGuiComponentLifeCycleEvent
{
    [Tooltip("Page‚Ì–¼‘O")]
    [SerializeField]
    private string _name = "";

    public string GetName()
    {
        return !string.IsNullOrWhiteSpace(_name) ? _name : nameof(gameObject.name);
    }

    public virtual async UniTask CloseIn()
    {

    }

    public virtual async UniTask CloseOut()
    {

    }

    public virtual async UniTask Initialize()
    {

    }

    public virtual async UniTask OpenIn()
    {

    }

    public virtual async UniTask OpenOut()
    {

    }
}
