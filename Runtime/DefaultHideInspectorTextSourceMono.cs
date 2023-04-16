

    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultHideInspectorTextSourceMono : AbstractTextSourceMono
{
    [Header("This is very low protection. Don't git that.")]
    public DefaultHideInspectorTextSource m_dontShowThisText;

    public override void GetText(out string text)
    {
        m_dontShowThisText.GetText(out text);
    }
}

[System.Serializable]
public class DefaultHideInspectorTextSource : AbstractTextSource
{
    public HiddenText m_hiddenTextSource;

    public override void GetText(out string text)
    {
        text = m_hiddenTextSource.m_hiddenText;
    }


    [System.Serializable]
    public class HiddenText
    {
        public string m_hiddenText;
    }
}