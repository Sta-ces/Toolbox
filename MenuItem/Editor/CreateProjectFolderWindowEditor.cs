using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;
using UnityEditor;

public class CreateProjectFolderWindowEditor : EditorWindow
{
    [MenuItem("Window/Create Project Folder")]
    public static void ShowWindow()
    {
        EditorWindow.GetWindow(typeof(CreateProjectFolderWindowEditor));
    }

    void OnGUI()
    {
        GUILayout.BeginHorizontal();
            GUILayout.Label("Path :", GUILayout.Width(50));
            m_path = GUILayout.TextField(m_path);
        GUILayout.EndHorizontal();

        GUILayout.Label("Folders to create :");

        foreach (FolderToCreate folder in m_listFolder.ToList())
        {
            GUILayout.BeginHorizontal();
                if (GUILayout.Button("-", GUILayout.Width(20)))
                    // Remove Folder
                    m_listFolder.Remove(folder);
                folder.m_activeFolder = GUILayout.Toggle(folder.m_activeFolder, folder.m_folder);
            GUILayout.EndHorizontal();
        }

        GUILayout.BeginHorizontal();
            if (GUILayout.Button("+", GUILayout.Width(20)))
                // Add Folder
                m_listFolder.Add(new FolderToCreate(newName,true));
            newName = GUILayout.TextField(newName);
        GUILayout.EndHorizontal();

        if (GUILayout.Button("Create Folders"))
            CreateProject(m_listFolder, m_path);
    }

    private void Awake()
    {
        DefaultFolder(m_listFolder);
    }

    private void DefaultFolder(List<FolderToCreate> _list)
    {
        _list.Add(new FolderToCreate("_Scenes",true));
        _list.Add(new FolderToCreate("Scripts", true));
        _list.Add(new FolderToCreate("Materials", true));
        _list.Add(new FolderToCreate("Prefabs", true));
    }

    [System.Serializable]
    public class FolderToCreate
    {
        public string m_folder = "";
        public bool m_activeFolder = true;

        public FolderToCreate(string _nameFolder, bool _bool)
        {
            m_folder = _nameFolder;
            m_activeFolder = _bool;
        }
    }

    public static void CreateProject(List<FolderToCreate> _folders, string _path)
    {
        foreach (FolderToCreate folder in _folders)
        {
            if(folder.m_activeFolder && !Directory.Exists(_path+"/"+folder.m_folder))
                AssetDatabase.CreateFolder(_path, folder.m_folder);
        }
        AssetDatabase.Refresh();
    }

    private List<FolderToCreate> m_listFolder = new List<FolderToCreate>();
    private string newName = "name of your folder";
    private string m_path = "Assets";
}
