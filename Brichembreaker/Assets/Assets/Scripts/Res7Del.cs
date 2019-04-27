using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Res7Del : MonoBehaviour {
	public static Image Res7;
	public static Sprite Rxn7Res;
	public static Sprite Black;

	//Initialization
	void Start () {
		Res7 = GetComponent<Image>();
		Rxn7Res = Resources.Load<Sprite>("Rxn7Res");
	}
	
	// Switches the Image Displayed for RxnImg
	public static void delpic() {
		if (GM.bricks == 13) {
			TimedDestroy.Destroy(Res7);
	}
}
}