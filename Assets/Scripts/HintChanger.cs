using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HintChanger : MonoBehaviour {

	public List<GameObject> listImage;

	public Button hintButton; 

	private int hintCurrentIndex = 0;

	void Start () {
		
	}

	public void OnHintButtonClick(){
		hintCurrentIndex += 1;

		if (hintCurrentIndex == listImage.Count - 1) {
			hintButton.transform.localScale = 
				new Vector3 (-1, 1, 1);
		} else {
			hintButton.transform.localScale = 
				new Vector3 (1, 1, 1);
		}

		if (hintCurrentIndex == listImage.Count) {
			hintCurrentIndex = 0;
		}

		for (int i = 0; i < listImage.Count; i++) {
			if (i == hintCurrentIndex) {
				listImage [i].gameObject.SetActive (true);
			} else {
				listImage [i].gameObject.SetActive (false);
			}
		}

	}
	

}
