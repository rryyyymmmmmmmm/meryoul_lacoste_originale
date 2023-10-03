using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class Character_part : MonoBehaviour
{
    UnityEngine.UI.Image _image;

    private void Start()
    {
        _image = GetComponent<Image>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == gameObject.tag)
        {
            Debug.Log(_image.sprite.name);
            Destroy(collision.gameObject);
        }    
    }
}
