using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class Level5ImageController : EventTrigger
{
	Vector3 distance;

	void Start ()
	{
		transform.localPosition = new Vector3 (
			Random.Range (-233, 230),
			Random.Range (-167, 193),
			0);
	}

	public override void OnBeginDrag(PointerEventData evData){
		Vector3 screenMousePos = Input.mousePosition;

		Vector3 worldMousePos = 
			Camera.main.ScreenToWorldPoint (screenMousePos);

		Vector3 canvasMousePos = 
			transform.parent.InverseTransformPoint (worldMousePos);

		distance = canvasMousePos - transform.localPosition;
			
	}



	public override void OnDrag (PointerEventData evData)
	{

		Vector3 screenMousePos = Input.mousePosition;

		Vector3 worldMousePos = 
			Camera.main.ScreenToWorldPoint (screenMousePos);

		Vector3 canvasMousePos = 
			transform.parent.InverseTransformPoint (worldMousePos);

		Vector3 expectedImagePos = canvasMousePos - distance;

		transform.localPosition = new Vector3(
			Mathf.Clamp(expectedImagePos.x,-233, 230),
			Mathf.Clamp(expectedImagePos.y,-167, 193),
			transform.localPosition.z
		) ;

	}

}
