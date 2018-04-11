using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttachMaterial : MonoBehaviour {
    Material m_Material;
    // Use this for initialization
    void Start () {

        print("Materials " + Resources.FindObjectsOfTypeAll(typeof(Material)).Length);
        m_Material = Resources.Load<Material>("Walls\\Stone_fldsgoor");
        GetComponent<MeshRenderer>().material = m_Material;
        MeshRenderer meshRenderer = gameObject.AddComponent<MeshRenderer>();
        meshRenderer.material = m_Material;
    }
	
	// Update is called once per frame
	void Update () {
        GetComponent<MeshRenderer>().material = m_Material;
    }
}
