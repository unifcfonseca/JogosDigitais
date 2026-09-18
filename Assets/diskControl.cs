using UnityEngine;

public class diskControl : MonoBehaviour
{
    private Rigidbody2D rb2d;   
    public AudioSource source; 

    void GoBall(){                      
        float rand = Random.Range(0, 2);
        if(rand < 1){
            rb2d.AddForce(new Vector2(20f, -15f));
        } else {
            rb2d.AddForce(new Vector2(-20f, -15f));
        }
    }

    void Start () {
        source = GetComponent<AudioSource>();
        rb2d = GetComponent<Rigidbody2D>(); 
        Invoke("GoBall", 2);    
    }

    void OnCollisionEnter2D (Collision2D coll) {
        if(coll.collider.CompareTag("Player")){
            source.Play();
            Vector2 vel;
            vel.x = rb2d.linearVelocity.x;
            vel.y = (rb2d.linearVelocity.y / 2) + (coll.collider.attachedRigidbody.linearVelocity.y / 3);
            rb2d.linearVelocity = vel;
        }
    }

    void ResetBall(){
        rb2d.linearVelocity = Vector2.zero;
        transform.position = Vector2.zero;
    }

    // Reinicializa o jogo
    void RestartGame(){
        ResetBall();
        Invoke("GoBall", 1);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
