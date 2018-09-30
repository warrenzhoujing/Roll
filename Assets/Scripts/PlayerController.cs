using UnityEngine;

public class PlayerController : MonoBehaviour {
    public Rigidbody2D rb2D;
    public float speed;
    float direction;

    void Start () {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
	}
	

	void Update () {
        direction = Input.GetAxisRaw("Horizontal");
        if (rb2D.velocity.x < 5)
        {
            rb2D.AddForce(Vector2.right * speed * direction * Time.deltaTime);
            transform.Rotate(Vector3.forward * 90 * speed * direction * Time.deltaTime);

        }
	}

}

