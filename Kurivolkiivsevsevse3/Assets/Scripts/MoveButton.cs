using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MoveButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
	[SerializeField] private MoveScript script;
	[SerializeField] private Vector3 vector;
	public void OnPointerEnter(PointerEventData eventData)
	{
		//script.SetVector(vector);
	}

	public void OnPointerExit(PointerEventData eventData)
	{
		//script.SetVector(Vector3.zero);
	}
}
