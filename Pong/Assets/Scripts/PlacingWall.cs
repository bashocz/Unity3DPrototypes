using UnityEngine;
using System.Collections;

public class PlacingWall : MonoBehaviour {

    public bool isUp;

	// Use this for initialization
	void Start () {
        Vector3 worldSize = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
        transform.position = new Vector3(transform.position.x, ((isUp) ? 1 : -1) * (worldSize.y - renderer.bounds.extents.y / 2), 0);
        transform.localScale = new Vector3(worldSize.x / renderer.bounds.extents.x, 1, 1);
	}
}
