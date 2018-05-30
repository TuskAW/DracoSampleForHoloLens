using UnityEngine;

public class ResourceMeshObject : MonoBehaviour
{
	public string AssetName = "";

	void Start()
	{
		Mesh mesh = MeshLoader.LoadMeshFromResources(AssetName);

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
	}
}
