using UnityEngine;

//����� �������� -- ������
//������� �������� ������ � ����� �� ������������ ��������.
public class WorkerWalking : MonoBehaviour
{
    [SerializeField]
    public float speed = 0.1f; // �������� �������� �������
    public float distance = 10.0f; // ����������, �� ������� ������� ������

    private Vector3 startPosition; // ��������� ������� �������
    private bool moveRight = true; // ����, ����������� ����������� ��������

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        // �������� ������� ������
        if (moveRight)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
            if (transform.position.x > startPosition.x + distance)
            {
                moveRight = false;
            }
        }
        // �������� ������� �����
        else
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
            if (transform.position.x < startPosition.x - distance)
            {
                moveRight = true;
            }
        }
    }
}
