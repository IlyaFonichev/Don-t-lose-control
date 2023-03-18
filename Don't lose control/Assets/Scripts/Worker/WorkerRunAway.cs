using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorkerRunAway : MonoBehaviour
{
    [SerializeField] private Transform _exit;
    [SerializeField] private int _speed = 10;

    private void FixedUpdate()
    {
        // Вычисляем направление к цели
        Vector2 direction = new Vector2(_exit.position.x - transform.position.x, 0);

        // Вычисляем расстояние до цели
        float distance = direction.magnitude;

        // Если расстояние больше, чем минимальное, двигаем объект
        if (distance > 0.1f)
        {
            // Нормализуем направление и умножаем на скорость
            Vector2 moveVector = direction.normalized * _speed;

            // Перемещаем объект
            transform.position = new Vector2(transform.position.x + moveVector.x * Time.deltaTime, transform.position.y);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
