using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FetchNotEmptyInListTextSourceMono : AbstractTextSourceMono
{

    public List<AbstractTextSourceMono> m_source;

    public override void GetText(out string text)
    {
        for (int i = 0; i < m_source.Count; i++)
        {
            if (m_source[i] != null) { 
                m_source[i].GetText(out text);
                if (text != null && text.Trim().Length > 0)
                    return;
            }
        }
        text="";
    }
}
