using Cysharp.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Page : MonoBehaviour, IGuiComponentLifeCycleEvent
{
    [Tooltip("Page‚Ì–¼‘O")]
    [SerializeField]
    private string _name = "";

    public string GetName()
    {
        return !string.IsNullOrWhiteSpace(_name) ? _name : nameof(gameObject.name);
    }

    public abstract UniTask CloseIn();

    public abstract UniTask CloseOut();

    public abstract UniTask Initialize();

    public abstract UniTask OpenIn();

    public abstract UniTask OpenOut();
}
