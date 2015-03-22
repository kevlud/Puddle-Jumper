using UnityEngine;
using System.Collections;
using HighlightingSystem;

public class HighlighterController : MonoBehaviour
{
	protected Highlighter h;
	
	// 
	protected void Awake()
	{
		h	 = GetComponent<Highlighter>();
		if (h == null) { h = gameObject.AddComponent<Highlighter>(); }
	}
	
	// 
	void OnEnable()
	{
		h.SeeThroughOff();
	}
	
	// 
	protected void Start() { }
	
	// 
	protected void Update()
	{

		
	}
	
	// 
	public void MouseOver()
	{
		// Highlight object for one frame in case MouseOver event has arrived
		h.On(Color.red);
	}
	
	// 
	public void Fire1()
	{
		// Switch flashing
		h.FlashingSwitch();
	}
	
	// 
	public void Fire2()
	{
		// Stop flashing
		h.SeeThroughSwitch();
	}
}