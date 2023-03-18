using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class WorkerBackWork : MonoBehaviour
{
    [SerializeField] private Transform _computer;
    [SerializeField] private int _speed = 10;

    private void FixedUpdate()
    {
        // ��������� ����������� � ����
        Vector2 direction = new Vector2(_computer.position.x - transform.position.x, 0);

        // ��������� ���������� �� ����
        float distance = direction.magnitude;

        // ���� ���������� ������, ��� �����������, ������� ������
        if (distance > 0.1f)
        {
            // ����������� ����������� � �������� �� ��������
            Vector2 moveVector = direction.normalized * _speed;

            // ���������� ������
            transform.position = new Vector2(transform.position.x + moveVector.x * Time.deltaTime, transform.position.y);
        }
        else
        {
            GetComponent<WorkerBackWork>().enabled = false;
        }
    }

}
