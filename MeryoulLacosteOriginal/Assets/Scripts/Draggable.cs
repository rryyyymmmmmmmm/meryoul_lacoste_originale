using UnityEngine.EventSystems;
using Unity.VisualScripting;
using UnityEngine;

public class Draggable : MonoBehaviour, IPointerDownHandler, IDragHandler
{
    private Vector2 offset;

    public void OnPointerDown(PointerEventData eventData)
    {
        // Calculate the offset between the mouse click position and the image's position
        offset = transform.position - (Vector3)eventData.position;
    }

    public void OnDrag(PointerEventData eventData)
    {
        // Update the image's position based on the mouse's current position
        transform.position = (Vector2)eventData.position + offset;
    }
}
