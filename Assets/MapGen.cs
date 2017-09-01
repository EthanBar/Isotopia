using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGen : MonoBehaviour {

    public GameObject tile;
    public int length;
    public float scale;
    [Range(0, 1)]
    public float plainStart;
    [Range(0, 1)]
    public float mountainStart;

	// Use this for initialization
	void Start () {
        float seed = Random.Range(-10000, 10000);
        for (int x = 0; x < length; x++) {
            for (int y = 0; y < length; y++) {
                GameObject newTile = Instantiate(tile, new Vector3(x, 0, y), Quaternion.identity);
                Tile tileInfo = newTile.GetComponent<Tile>();
                float sample = Mathf.PerlinNoise((x * scale) + seed, (y * scale) + seed);
                print(sample);
                if (sample >= mountainStart) {
                    tileInfo.SetTerrain(TerrainType.mountain);
                } else if (sample >= plainStart) {
                    tileInfo.SetTerrain(TerrainType.plain);
                } else {
                    tileInfo.SetTerrain(TerrainType.ocean);
                }
            }
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
