using UnityEngine;
using System.Collections;
using HighlightingSystem;

public class Glyph : MonoBehaviour
{
	
	protected Highlighter h;
	public bool blikani = false;
	public bool vybrano = false;
	public Color color = new Color(0.2F, 0.3F, 0.4F, 0.5F);
	// 
	protected void Awake()
	{
		h	 = GetComponent<Highlighter>();
		if (h == null) { h = gameObject.AddComponent<Highlighter>(); }
	}
	
	// 
	void OnEnable()
	{
		h.SeeThroughOn();
	}
	
	// 
	protected void Start() { 
		h.SeeThroughOn();
	}
	
	// 
	protected void Update()
	{
		vybrano = false;
	}
	
	// 
	public void MouseOver()
	{
		// Highlight object for one frame in case MouseOver event has arrived
		if (!blikani)
			h.On ();
		vybrano = true;
	}
	
	// 
	public void Fire1()
	{
		// Switch flashing
		h.FlashingSwitch();
		blikani = !blikani;
	}
	
	// 
	public void Fire2()
	{
		// Stop flashing
		h.SeeThroughSwitch();
	}
}