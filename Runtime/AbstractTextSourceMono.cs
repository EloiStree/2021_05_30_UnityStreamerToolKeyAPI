using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface IAbstractTextSource
{

    public void GetText(out string text);
    public string GetText();
}
public abstract class AbstractTextSource : IAbstractTextSource
{
    public abstract void GetText(out string text);
    public string GetText() { GetText(out string t); return t; }
}
public abstract class AbstractTextSourceMono : MonoBehaviour, IAbstractTextSource
{
    public abstract void GetText(out string text);
    public string GetText() { GetText(out string t); return t; }
}


