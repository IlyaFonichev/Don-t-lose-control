using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] 
    private float speed = 10f;
    private Rigidbody2D _rigidBody;
    private static Stress _playerStress;

    
    private void Start()
    {
        _playerStress = new Stress(10, 100);
        PlayerStaticEvents.changeStressInterface?.Invoke(_playerStress);

        _rigidBody = gameObject.GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxisRaw("Horizontal");
        Vector2 direction = new Vector2(moveHorizontal, 0);

        move(direction);
    }

    private void move(Vector2 direction)
    {
        _rigidBody.velocity = direction.normalized * speed;
    }

    public static Stress GetPlayerStress() { return _playerStress; }
}
