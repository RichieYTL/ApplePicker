using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class ApplePicker : MonoBehaviour {

	public GameObject basketPrefab;
	public List<GameObject> basketList;
	public int numBaskets = 3;
	public float basketBottomY = -14f;
	public float basketSpacingY = 2f;

	// Use this for initialization
	void Start () {
		basketList = new List<GameObject> ();
		for (int i = 0; i < numBaskets; i++) {
			//Gibson loves to name temporary variables with t to begin
			GameObject tBasketGo = Instantiate (basketPrefab) as GameObject;
			Vector3 pos = Vector3.zero;
			pos.y = basketBottomY + (basketSpacingY * i);
			tBasketGo.transform.position = pos;
			basketList.Add (tBasketGo);
		}
	}

	public void AppleDestroyed(){
		//Destroy all apples on failure
		GameObject[] tAppleArray = GameObject.FindGameObjectsWithTag ("Apple");
		foreach(GameObject tGo in tAppleArray){
				Destroy (tGo);
		}

		//Destroy a basket
		int basketIndex = basketList.Count - 1;
		GameObject tBasketGO = basketList [basketIndex];
		basketList.RemoveAt (basketIndex); //Getting rid of the reference to the GO and out of our database.
		Destroy (tBasketGO); //Actually destroy the GO now.
	}
}
