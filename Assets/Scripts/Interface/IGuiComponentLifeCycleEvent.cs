using Cysharp.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IGuiComponentLifeCycleEvent
{
    /// <summary>
    /// ����������
    /// </summary>
    UniTask Initialize();

    /// <summary>
    /// Open�ŕ\������Ƃ�
    /// </summary>
    UniTask OpenIn();

    /// <summary>
    /// �O�̖ʂ�Open���ĉB���Ƃ�
    /// </summary>
    UniTask OpenOut();

    /// <summary>
    /// �O�ʂ�Close���ĕ\�������Ƃ�
    /// </summary>
    UniTask CloseIn();

    /// <summary>
    /// Close�Ŕ�\���ɂ���Ƃ�
    /// </summary>
    UniTask CloseOut();
}
