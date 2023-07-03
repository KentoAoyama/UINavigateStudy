using Cysharp.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGuiComponentLifeCycleEvent
{
    /// <summary>
    /// 初期化処理
    /// </summary>
    UniTask Initialize();

    /// <summary>
    /// Openで表示するとき
    /// </summary>
    UniTask OpenIn();

    /// <summary>
    /// 前の面がOpenして隠れるとき
    /// </summary>
    UniTask OpenOut();

    /// <summary>
    /// 前面がCloseして表示されるとき
    /// </summary>
    UniTask CloseIn();

    /// <summary>
    /// Closeで非表示にするとき
    /// </summary>
    UniTask CloseOut();
}
