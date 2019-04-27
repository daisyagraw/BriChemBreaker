using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]

public class RxnDisplay : MonoBehaviour {
	public static Image RxnImg;
	public static Sprite Rxn1Pro;
	public static Sprite Rxn2Pro;
	public static Sprite Rxn3Pro;
	public static Sprite Rxn4Pro;
	public static Sprite Rxn5Pro;
	public static Sprite Rxn6Pro;
	public static Sprite Rxn7Pro;
	public static Sprite Rxn8Pro;
	public static Sprite Rxn9Pro;
	public static Sprite Rxn10Pro;
	public static Sprite Rxn11Pro;
	public static Sprite Rxn12Pro;
	public static Sprite Rxn13Pro;
	public static Sprite Rxn14Pro;
	public static Sprite Rxn15Pro;
	public static Sprite Rxn16Pro;
	public static Sprite Rxn17Pro;
	public static Sprite Rxn18Pro;
	public static Sprite Rxn19Pro;
	public static Sprite Rxn20Pro;
	private static int Rxncount = 1;

	//Initialization
	void Start () {
		RxnImg = GetComponent<Image>();
		Rxn1Pro = Resources.Load<Sprite>("Rxn1Pro");
        Rxn2Pro = Resources.Load<Sprite>("Rxn2Pro");
		Rxn3Pro = Resources.Load<Sprite>("Rxn3Pro");
		Rxn4Pro = Resources.Load<Sprite>("Rxn4Pro");
		Rxn5Pro = Resources.Load<Sprite>("Rxn5Pro");
		Rxn6Pro = Resources.Load<Sprite>("Rxn6Pro");
		Rxn7Pro = Resources.Load<Sprite>("Rxn7Pro");
		Rxn8Pro = Resources.Load<Sprite>("Rxn8Pro");
		Rxn9Pro = Resources.Load<Sprite>("Rxn9Pro");
		Rxn10Pro = Resources.Load<Sprite>("Rxn10Pro");
		Rxn11Pro = Resources.Load<Sprite>("Rxn11Pro");
		Rxn12Pro = Resources.Load<Sprite>("Rxn12Pro");
		Rxn13Pro = Resources.Load<Sprite>("Rxn13Pro");
		Rxn14Pro = Resources.Load<Sprite>("Rxn14Pro");
		Rxn15Pro = Resources.Load<Sprite>("Rxn15Pro");
		Rxn16Pro = Resources.Load<Sprite>("Rxn16Pro");
		Rxn17Pro = Resources.Load<Sprite>("Rxn17Pro");
		Rxn18Pro = Resources.Load<Sprite>("Rxn18Pro");
		Rxn19Pro = Resources.Load<Sprite>("Rxn19Pro");
		Rxn20Pro = Resources.Load<Sprite>("Rxn20Pro");
		
	}
	
	// Switches the Image Displayed for RxnImg
	public static void swtchRxn() {
		Rxncount++;
		if (Rxncount == 2) {
			RxnImg.overrideSprite = Rxn2Pro;
			}
		else if (Rxncount == 3) {
			RxnImg.overrideSprite = Rxn3Pro;
			}
		else if (Rxncount == 4) {
			RxnImg.overrideSprite = Rxn4Pro;}
		else if (Rxncount == 5) {
			RxnImg.overrideSprite = Rxn5Pro;
		}
		else if (Rxncount == 6) {
			RxnImg.overrideSprite = Rxn6Pro;
			}
		else if (Rxncount == 7) {
			RxnImg.overrideSprite = Rxn7Pro;
			}
		else if (Rxncount == 8) {
			RxnImg.overrideSprite = Rxn8Pro;
			}
		else if (Rxncount == 9) {
			RxnImg.overrideSprite = Rxn9Pro;
			}
		else if (Rxncount == 10) {
			RxnImg.overrideSprite = Rxn10Pro;
			}
		else if (Rxncount == 11) {
			RxnImg.overrideSprite = Rxn11Pro;
			}
		else if (Rxncount == 12) {
			RxnImg.overrideSprite = Rxn12Pro;
			}
		else if (Rxncount == 13) {
			RxnImg.overrideSprite = Rxn13Pro;
			}
		else if (Rxncount == 14) {
			RxnImg.overrideSprite = Rxn14Pro;
			}
		else if (Rxncount == 15) {
			RxnImg.overrideSprite = Rxn15Pro;
			}
		else if (Rxncount == 16) {
			RxnImg.overrideSprite = Rxn16Pro;
			}
		else if (Rxncount == 17) {
			RxnImg.overrideSprite = Rxn17Pro;
			}
		else if (Rxncount == 18) {
			RxnImg.overrideSprite = Rxn18Pro;
			}
		else if (Rxncount == 19) {
			RxnImg.overrideSprite = Rxn19Pro;
			}
		else if (Rxncount == 20) {
			RxnImg.overrideSprite = Rxn20Pro;
			}
		else if (Rxncount == 21) {
			RxnImg.overrideSprite = null;
			}
		
		
	}
}
