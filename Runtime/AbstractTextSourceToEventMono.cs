using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AbstractTextSourceToEventMono : MonoBehaviour
{
    public StringEvent m_onSourceLoaded;
    public AbstractTextSourceMono m_source;
    public bool m_loadItAtAwake;

    [System.Serializable]
    public class StringEvent : UnityEvent<string> { };

    private void Awake()
    {
        if (m_loadItAtAwake)
            LoadAndPush();
    }
    [ContextMenu("Load Source")]
    private void LoadAndPush()
    {
        m_source.GetText(out string text);
        m_onSourceLoaded.Invoke(text);
    }
}
