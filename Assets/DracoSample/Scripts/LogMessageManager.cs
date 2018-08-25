using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogMessageManager : MonoBehaviour
{
	public TextMesh textMesh = null;

	void OnEnable()
	{
		Application.logMessageReceived += LogMessageReceived; 
	}

	private void LogMessageReceived(string logString, string stackTrace, LogType type)
	{
		if(textMesh != null)
		{
			textMesh.text += logString + System.Environment.NewLine;
		}
	}
}
