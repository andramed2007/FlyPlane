using UnityEditor.Rendering;
using UnityEngine.InputSystem;
using UnityEngine;

public class MovePlane : MonoBehaviour
{
 [SerializeField]  float moveSpeed = 5f;
    bool PresedUp = false;
    bool PresedDown = false;
    Rigidbody2D rb;
    

    void Start()
    {
    
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
     

        PresedUp = (Input.GetKey(KeyCode.W) | Input.GetKey(KeyCode.UpArrow));
        PresedDown = (Input.GetKey(KeyCode.S) | Input.GetKey(KeyCode.DownArrow));

        if (PresedUp)
        {
           rb.linearVelocity = new Vector2(0f,moveSpeed);
        }
        else
        {
            if(!PresedDown) rb.linearVelocity = new Vector2(0f,0f);
        }
        if(PresedDown)
        {
           rb.linearVelocity = new Vector2(0f,-moveSpeed);
        }
        else
        {
            if(!PresedUp) rb.linearVelocity = new Vector2(0f,0f);
        }
        
        
    }

   
}

