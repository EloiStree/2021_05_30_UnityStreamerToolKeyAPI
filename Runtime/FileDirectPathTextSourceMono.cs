using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class FileDirectPathTextSourceMono : AbstractTextSourceMono
{
    public string m_filePathTextSource;
    //public bool m_createFileIfNotExisting;
    //public string m_expectedTextCommentInFile;
    public override void GetText(out string text)
    {
        if (File.Exists(m_filePathTextSource))
        {
            text = File.ReadAllText(m_filePathTextSource);
        }
        else text = "";
        //else {
        //    if (m_createFileIfNotExisting)
        //    {
        //        Directory.CreateDirectory(Path.GetDirectoryName(m_filePathTextSource));
        //        File.WriteAllText(m_filePathTextSource, m_expectedTextCommentInFile);
        //    }
        //}
        
    }
}
