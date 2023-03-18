using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] 
    private float speed = 10f;
    private Rigidbody2D _rigidBody;
    private static Stress _playerStress;

    private float calmness;
    public static PlayerController _instance;



    private void Start()
    {
        if (_instance == null)
            _instance = this;
        else
            Destroy(gameObject);


        _playerStress = new Stress(70, 100);
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
    public float getCalmness {get { return calmness; }}
}
