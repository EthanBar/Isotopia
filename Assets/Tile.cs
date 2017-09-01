using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour {

    bool hasUnit;
    TerrainType terrainType;
    Renderer render;

    public Material ocean;
    public Material plain;
    public Material mountain;

	// Use this for initialization
	void Start () {
        hasUnit = false;
        transform.SetParent(GameObject.Find("MapGen").transform);
	}
	
	// Update is called once per frame
	void Update () {
        
	}

    public void SetTerrain(TerrainType type) {
        render = GetComponent<Renderer>();
        terrainType = type;
        if (terrainType == TerrainType.mountain) render.material = mountain;
        else if (terrainType == TerrainType.plain) render.material = plain;
        else render.material = ocean;

        Vector3 pos = transform.position;
        if (terrainType == TerrainType.plain) pos.y += 0.2f;
        if (terrainType == TerrainType.mountain) pos.y += 0.4f;
        transform.position = pos;
    }
}

public enum TerrainType {
    ocean,
    plain,
    mountain
}