using System;
using UnityEngine;

public class ResourceMeshObject : MonoBehaviour
{
	public string AssetName = "";
	private DateTime previous = DateTime.Now;

	void Start()
	{
		DateTime start = DateTime.Now;
		Mesh mesh = MeshLoader.LoadMeshFromResources(AssetName);
		DateTime end = DateTime.Now;

		Debug.Log("Loading time: " + (end.Ticks - start.Ticks)*100.0f + "[ns]");
		Debug.Log("Loading time: " + (end.Ticks - start.Ticks)*0.0001f + "[ms]");

		MeshFilter filter = GetComponent<MeshFilter>();
		if(filter == null)
		{
			filter = gameObject.AddComponent<MeshFilter>();
		}
		filter.mesh = mesh;

		if(GetComponent<MeshRenderer>() == null)
		{
			MeshRenderer renderer = gameObject.AddComponent<MeshRenderer>();
			renderer.material = new Material(Shader.Find("Legacy Shaders/Diffuse"));;
		}

		previous = DateTime.Now;
	}

	void Update()
	{
		DateTime current = DateTime.Now;
		Debug.Log("Frame time: " + (current.Ticks - previous.Ticks)*0.0001f + "[ms]");
		previous = current;
	}
}
