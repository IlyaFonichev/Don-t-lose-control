using UnityEngine;

public class Worker : MonoBehaviour
{
    private WorkerWalking _workerWalking;
    private WorkerBackWork _workerWork;
    private WorkerRunAway _workerRunAway;

    private void Start()
    {
        _workerWalking = GetComponent<WorkerWalking>();
        _workerWork = GetComponent<WorkerBackWork>();
        _workerRunAway = GetComponent<WorkerRunAway>();
    }

    private void OnMouseDown()
    {
        if (_workerWalking.enabled == true)
        {
            _workerWalking.enabled = false;
            _workerWork.enabled = true;
        }else if (_workerWork.enabled == true)
        {
            //подождать секунд 10-15 и включить скрипт гуляния
        }
        
    }




}
