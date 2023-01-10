using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeImage1 : MonoBehaviour
{   
    
    public SpriteRenderer sprite;
    public Sprite sprite_to_change_to;
    public void OnMouseDown()
    {
        sprite.sprite = sprite_to_change_to;
        ScoreManager.instance.AddPoint();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
