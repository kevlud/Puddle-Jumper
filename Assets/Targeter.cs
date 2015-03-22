using UnityEngine;
using System.Collections;

public class Targeter : MonoBehaviour {

	public Texture2D crosshairTexture;
	public float crosshairScale = 1;

	// Use this for initialization
	void Start () {

	}
	public GameObject pointer;
	// Update is called once per frame
	void Update () {
		Transform targetTransform = null;
		RaycastHit hit;

		Vector3 fwd = pointer.transform.TransformDirection(Vector3.forward);
		if (Physics.Raycast(pointer.transform.position, fwd,out hit)){
			Debug.DrawLine(pointer.transform.position, hit.point);
			targetTransform = hit.collider.transform;
			if(hit.collider.tag == "selectable"){
				//print("HAHA");
			}
		}

		// If we've hit an object during raycast
		if (targetTransform != null)
		{
			// And this object has HighlighterController component
			//HighlighterController hc = targetTransform.GetComponentInParent<HighlighterController>();
			Glyph glyph = targetTransform.GetComponentInParent<Glyph>();

			if(glyph != null){
				glyph.MouseOver();
			}
		}
	}

	void OnGUI()
	{
		//if not paused
		if(Time.timeScale != 0)
		{
			if(crosshairTexture!=null){
				GUI.DrawTexture(new Rect((Screen.width/2-crosshairTexture.width*crosshairScale)/2 ,(Screen.height-crosshairTexture.height*crosshairScale)/2, crosshairTexture.width*crosshairScale, crosshairTexture.height*crosshairScale),crosshairTexture);
				GUI.DrawTexture(new Rect((Screen.width/2-crosshairTexture.width*crosshairScale)/2 + Screen.width/2 , ((Screen.height)-crosshairTexture.height*crosshairScale)/2 ,crosshairTexture.width*crosshairScale,crosshairTexture.height*crosshairScale),crosshairTexture);
			}
			else
				Debug.Log("No crosshair texture set in the Inspector");
		}
	}
}
