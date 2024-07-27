using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultInspectorTextSourceMono :  AbstractTextSourceMono
{
    public string m_text;

    public override void GetText(out string text)
    {
        text = m_text;
    }
}

[System.Serializable]
public class DefaultInspectorTextSource : AbstractTextSource
{
    public string m_text;

    public override void GetText(out string text)
    {
        text = m_text;
    }
}