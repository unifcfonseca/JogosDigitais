using UnityEngine;

public class player2Control : MonoBehaviour
{
    private Rigidbody2D rb2d;    
    public float boundY = 7.1f; 
    public float boundX = 4.2f;     
    float speed = 3f;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 ballPos = GameObject.Find("Ball_0").transform.position;;

        Vector3 playerPos = transform.position;

        Vector3 dir = ballPos - playerPos;
        dir.Normalize();

        Vector3 speedVec = dir * speed;
        var vel = rb2d.linearVelocity;
        vel.x = speedVec.x;
        vel.y = speedVec.y;
        rb2d.linearVelocity = vel;   

        if (playerPos.y < 1) {                  
            playerPos.y = 1;                     
        }
        else if (playerPos.y > boundY) {
            playerPos.y = boundY;                   
        }
        if (playerPos.x > boundX) {                  
            playerPos.x = boundX;                     
        }
        else if (playerPos.x < -boundX) {
            playerPos.x = -boundX;                   
        }
        transform.position = playerPos;     

        
    }
}
