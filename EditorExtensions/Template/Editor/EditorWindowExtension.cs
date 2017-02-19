/*
 * Must be located in a folder called "Editor"
 * Note: the %l is the shortcut for opening this window in unity. % = Alt/CMD button
 */

using UnityEngine;
using UnityEditor;
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Assertions;

public class EditorWindowExtension : EditorWindow
{


	[MenuItem("Window/Language Editor %l")]
	public static void ShowEditor()
	{

		//create the editor window
		EditorWindowExtension editor = EditorWindow.GetWindow<EditorWindowExtension>();
		//the editor window must have a min size
		editor.titleContent = new GUIContent("Editor");
		editor.minSize = new Vector2 (600, 400);
		//call the init method after we create our window
		editor.Init();

	}


	private void Init()
	{

	}

	private void OnGUI()
	{

		
	}

	//UNITY EVENTS START

	public void PlaymodeChanged()
	{

		Repaint();
	}

	public void OnLostFocus ()
	{

		Repaint();
	}

	public void OnFocus()
	{

		Repaint();
	}

	public void OnProjectChange ()
	{

		Repaint();
	}

	public void OnSelectionChange ()
	{

		Repaint();
	}
	//UNITY EVENTS END


}
