using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkerRunAway : MonoBehaviour
{
    [SerializeField] private Transform _exit;
    [SerializeField] private int _speed = 10;

    private void FixedUpdate()
    {
        // ��������� ����������� � ����
        Vector2 direction = new Vector2(_exit.position.x - transform.position.x, 0);

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
            Destroy(gameObject);
        }
    }
}
