using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardforce = 2000f;
    public float sidewayforce = 200f;
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0 ,forwardforce * Time.deltaTime);

        if(Input.touchCount > 0)
        {
            Touch moving = Input.GetTouch(0);
            if(moving.position.x > Screen.width/2)
            {
                rb.AddForce(sidewayforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
            else if(moving.position.x <= Screen.width / 2)
            {
                rb.AddForce(-sidewayforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }
        }

        if(rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EngGame();
        }
      
    }
}
