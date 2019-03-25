using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Render : MonoBehaviour {

	Renderer renderer;

	Material material;

	public Color color;

	void Start()
	{
		renderer = GetComponent<Renderer>();
		material = renderer.sharedMaterial;

		//can be set in the inspector
		material.globalIlluminationFlags = MaterialGlobalIlluminationFlags.RealtimeEmissive;
	}

	void Update()
	{
		material.SetColor("_EmissionColor", color);
 //		DynamicGI.UpdateMaterials(renderer);
		DynamicGI.UpdateEnvironment();
	} private void Test(GameObject obj)
	{
		MeshRenderer mr = obj.GetComponent<MeshRenderer>();
		mr.material.SetColor("_EmissionColor", Color.yellow);
		bool shouldEmissionBeEnabled = ShouldEmissionBeEnabled(mr.material.GetColor("_EmissionColor"));
		if (shouldEmissionBeEnabled)
		{
			mr.material.EnableKeyword("_EMISSION");
		}
		else
		{
			mr.material.DisableKeyword("_EMISSION");
		}
	}
	static bool ShouldEmissionBeEnabled(Color color)
	{
		return color.maxColorComponent > (0.1f / 255.0f);
	}
}
