
using UnityEngine;
using UnityEngine.EventSystems;
using Unity.VisualScripting;

public class Item : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler
{
    private Vector2 offset;
    private Transform item_pos;


    private void Start()
    {
        item_pos = transform;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        // Calculate the offset between the mouse click position and the image's position
        Transform UI = Instantiate(transform, eventData.position , transform.localRotation);
        transform.AddComponent<Rigidbody2D>();
        
        UI.transform.rotation = transform.rotation;
        UI.transform.position = item_pos.position;
        UI.transform.localScale = item_pos.lossyScale;
        UI.SetParent(transform.parent);

        offset = transform.position - (Vector3)eventData.position;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        // Destroy the GameObject when the mouse button is released
        //Destroy(gameObject);
        Debug.Log('+');
    }

    public void OnDrag(PointerEventData eventData)
    {
        // Update the image's position based on the mouse's current position
        transform.position = (Vector2)eventData.position + offset;
    }
}
