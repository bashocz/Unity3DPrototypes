using UnityEngine;
using System.Collections;

public class PieceTimeMoving : MonoBehaviour
{
		private float _speed = 1.0f;
		private float _timer;
		private int _idx = 0;
		private Vector3[] positions;

		// Use this for initialization
		void Start ()
		{
				positions = new Vector3[72];

				// start BLUE
				positions [0] = new Vector3 (-0.6123226f, -1.990049f, 0);
				positions [1] = new Vector3 (-0.6123226f, -1.500191f, 0);
				positions [2] = new Vector3 (-0.5970145f, -1.010333f, 0);
				positions [3] = new Vector3 (-0.5970145f, -0.5510908f, 0);
				positions [4] = new Vector3 (-0.5817064f, -0.09184882f, 0);
				positions [5] = new Vector3 (-1.163413f, -0.09184882f, 0);
				positions [6] = new Vector3 (-1.760428f, -0.09184878f, 0);
				positions [7] = new Vector3 (-2.342134f, -0.09184878f, 0);
				positions [8] = new Vector3 (-2.923841f, -0.0918488f, 0);
				positions [9] = new Vector3 (-2.893224f, 0.3520851f, 0);
				// start YELLOW
				positions [10] = new Vector3 (-2.862608f, 0.7960191f, 0);
				positions [11] = new Vector3 (-2.280902f, 0.7960191f, 0);
				positions [12] = new Vector3 (-1.714504f, 0.7960191f, 0);
				positions [13] = new Vector3 (-1.148105f, 0.796019f, 0);
				positions [14] = new Vector3 (-0.5663985f, 0.796019f, 0);
				positions [15] = new Vector3 (-0.5663985f, 1.224645f, 0);
				positions [16] = new Vector3 (-0.5510904f, 1.637963f, 0);
				positions [17] = new Vector3 (-0.5510904f, 2.05128f, 0);
				positions [18] = new Vector3 (-0.5510904f, 2.44929f, 0);
				positions [19] = new Vector3 (0f, 2.44929f, 0);
				// start GREEN
				positions [20] = new Vector3 (0.5510903f, 2.44929f, 0);
				positions [21] = new Vector3 (0.5510903f, 2.05128f, 0);
				positions [22] = new Vector3 (0.5663983f, 1.637963f, 0);
				positions [23] = new Vector3 (0.5663983f, 1.209337f, 0);
				positions [24] = new Vector3 (0.5663983f, 0.7960193f, 0);
				positions [25] = new Vector3 (1.148105f, 0.7960193f, 0);
				positions [26] = new Vector3 (1.714503f, 0.7960193f, 0);
				positions [27] = new Vector3 (2.29621f, 0.7960193f, 0);
				positions [28] = new Vector3 (2.862608f, 0.7960193f, 0);
				positions [29] = new Vector3 (2.893224f, 0.3673935f, 0);
				// start RED
				positions [30] = new Vector3 (2.92384f, -0.09184849f, 0);
				positions [31] = new Vector3 (2.342134f, -0.09184849f, 0);
				positions [32] = new Vector3 (1.760427f, -0.09184849f, 0);
				positions [33] = new Vector3 (1.163413f, -0.09184849f, 0);
				positions [34] = new Vector3 (0.5817062f, -0.09184849f, 0);
				positions [35] = new Vector3 (0.5970142f, -0.5510905f, 0);
				positions [36] = new Vector3 (0.5970142f, -1.01f, 0);
				positions [37] = new Vector3 (0.6123223f, -1.499858f, 0);
				positions [38] = new Vector3 (0.6123223f, -1.989716f, 0);
				positions [39] = new Vector3 (0f, -1.989716f, 0);

				// home BLUE
				positions [40] = new Vector3 (0, -1.499858f, 0);
				positions [41] = new Vector3 (0, -1.01f, 0);
				positions [42] = new Vector3 (0, -0.550758f, 0);
				positions [43] = new Vector3 (0, -0.07620794f, 0);
				// home YELLOW
				positions [44] = new Vector3 (-2.311518f, 0.367726f, 0);
				positions [45] = new Vector3 (-1.729812f, 0.3677259f, 0);
				positions [46] = new Vector3 (-1.148105f, 0.3677259f, 0);
				positions [47] = new Vector3 (-0.5817069f, 0.3677259f, 0);
				// home GREEN
				positions [48] = new Vector3 (0, 2.051613f, 0);
				positions [49] = new Vector3 (0, 1.638295f, 0);
				positions [50] = new Vector3 (0, 1.224978f, 0);
				positions [51] = new Vector3 (0, 0.7963518f, 0);
				// home RED
				positions [52] = new Vector3 (2.311517f, 0.3524179f, 0);
				positions [53] = new Vector3 (1.745119f, 0.352418f, 0);
				positions [54] = new Vector3 (1.163412f, 0.352418f, 0);
				positions [55] = new Vector3 (0.5817058f, 0.352418f, 0);
		
				// paddock BLUE
				positions [56] = new Vector3 (-2.433983f, -1.499858f, 0);
				positions [57] = new Vector3 (-2.403367f, -1.01f, 0);
				positions [58] = new Vector3 (-1.791044f, -1.025308f, 0);
				positions [59] = new Vector3 (-1.82166f, -1.515166f, 0);
				// paddock YELLOW
				positions [60] = new Vector3 (-2.234978f, 1.638296f, 0);
				positions [61] = new Vector3 (-2.204362f, 2.051613f, 0);
				positions [62] = new Vector3 (-1.653272f, 2.051613f, 0);
				positions [63] = new Vector3 (-1.66858f, 1.638296f, 0);
				// paddock GREEN
				positions [64] = new Vector3 (1.668579f, 1.653604f, 0);
				positions [65] = new Vector3 (1.65327f, 2.036305f, 0);
				positions [66] = new Vector3 (2.204361f, 2.051613f, 0);
				positions [67] = new Vector3 (2.234977f, 1.638295f, 0);
				// paddock RED
				positions [68] = new Vector3 (1.806351f, -1.499858f, 0);
				positions [69] = new Vector3 (1.806351f, -1.01f, 0);
				positions [70] = new Vector3 (2.403365f, -1.01f, 0);
				positions [71] = new Vector3 (2.433981f, -1.499858f, 0);

				renderer.transform.position = positions [0];
		}
	
		// Update is called once per frame
		void Update ()
		{
				if (_timer > 0.0f)
						_timer -= Time.deltaTime;
				if (_timer <= 0.0f) {
						_timer += _speed;

						_idx++;
						if (_idx > 71)
								_idx = 0;

						renderer.transform.position = positions [_idx];
				}
		}
}
