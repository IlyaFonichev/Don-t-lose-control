using UnityEngine;

//Режим рабочего -- шароеб
//Двигает рабочего вправо и влево на определенную дистанию.
public class WorkerWalking : MonoBehaviour
{
    [SerializeField]
    public float speed = 0.1f; // скорость движения объекта
    public float distance = 10.0f; // расстояние, на которое двигать объект

    private Vector3 startPosition; // начальная позиция объекта
    private bool moveRight = true; // флаг, указывающий направление движения

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        // движение объекта вправо
        if (moveRight)
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
            if (transform.position.x > startPosition.x + distance)
            {
                moveRight = false;
            }
        }
        // движение объекта влево
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
