using UnityEngine;


public class mouseControl : MonoBehaviour
{
    private Rigidbody2D rb2d;    
    public float boundY = 7.1f; 
    public float boundX = 4.2f; 
    float speed = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        var pos = transform.position;
        pos.x = mousePos.x;
        pos.y = mousePos.y;
        transform.position = pos;
        if (pos.y > -1) {                  
            pos.y = -1;                     
        }
        else if (pos.y < -boundY) {
            pos.y = -boundY;                   
        }
        if (pos.x > boundX) {                  
            pos.x = boundX;                     
        }
        else if (pos.x < -boundX) {
            pos.x = -boundX;                   
        }
        transform.position = pos;       

    }
}
