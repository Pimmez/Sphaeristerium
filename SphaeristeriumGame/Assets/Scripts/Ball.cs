using UnityEngine;

public class Ball : MonoBehaviour, IReset
{
	public Vector3 ResetPosition { get { return startPosition; } set { startPosition = value; } }

	[SerializeField] private float speed = 10f;
	private Vector3 startPosition;
	private Rigidbody rb;

	private void Awake()
	{
		rb = GetComponent<Rigidbody>();
	}

	public void ResetBall()
	{
		rb.angularVelocity = Vector3.zero;
		rb.velocity = Vector3.zero;
		transform.position = startPosition;
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == Tags.Paddle)
		{
			float _x = UtilityMath.HitFactor(transform.position, collision.transform.position, collision.collider.bounds.size.x);

			Vector2 _dir = new Vector2(_x, 1).normalized;
			rb.velocity = _dir * speed;
		}
	}
}