using UnityEngine;

public class PointWalls : MonoBehaviour
{
    void OnTriggerEnter2D (Collider2D hitInfo) {
        if (hitInfo.tag == "ball")
        {
            string wallName = transform.name;
            gameManager.Score(wallName);
            hitInfo.gameObject.SendMessage("RestartGame", null, SendMessageOptions.RequireReceiver);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
