using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Swap : MonoBehaviour { 
    private Image targetImage; // Reference to the UI Image of the target object.
    public Image newSprite;  // The new sprite to be applied to the target.

    private string UpperSpriteName = "UPPER_01";
    private string UpperDefaultSpriteName = "UPPER_DEFAULT";

    private string LowerSpriteName = "LOWER_01";
    private string LowerDefaultSpriteName = "LOWER_DEFAULT";

    private string FeetSpriteName = "FEET_01";
    private string FeetDefaultSpriteName = "FEET_DEFAULT";

    private string HeadSpriteName = "HEAD_01";
    private string HeadDefaultSpriteName = "HEAD_DEFAULT";



    void Start()
    {
        newSprite = GetComponent<Image>();
    }
    /*public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }*/

    /*public void OnEndDrag(PointerEventData eventData)
    {
        if (RectTransformUtility.RectangleContainsScreenPoint(targetImage.rectTransform, Input.mousePosition))
        {
            // Change the sprite of the target UI Image.
            targetImage.sprite = newSprite;
        }
    }*/

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == gameObject.tag)
        {
            Sprite temp;
            targetImage = collision.gameObject.GetComponent<Image>();
            switch (gameObject.tag)
            {
                case "Head":
                    temp = Resources.Load<Sprite>(HeadSpriteName);
                    break;
                case "Upper body":
                    temp = Resources.Load<Sprite>(UpperSpriteName);
                    break;
                case "Lower body":
                    temp = Resources.Load<Sprite>(LowerSpriteName);
                    break;
                case "Legs":
                    temp = Resources.Load<Sprite>(FeetSpriteName);
                    break;
                    default: temp = null;
                    break;
            }
            if(temp != null)
            {
                targetImage.sprite = temp;
                targetImage.preserveAspect = true;
            }
            else
            {
                Debug.Log("Error cant assign sprite");
            }
            
        }
    }
}