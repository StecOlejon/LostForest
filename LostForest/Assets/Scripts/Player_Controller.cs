using UnityEngine;

public class Player_Controller : MonoBehaviour
{
   public float speed;
   private Vector2 direction;
   private Rigidbody2D rb;
   
   void Start()
   {
   	rb = GetComponent<Rigidbody2D>();
   }
   
   void Update()
   {
	direction.x = Input.GetAxisRaw("Horizontal");
	direction.y = Input.GetAxisRaw("Vertical");
   }
   
   void FixedUpdate() 
  
   {
	rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime);
   }
}
