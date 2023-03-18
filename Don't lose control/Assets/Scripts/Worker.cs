using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Worker : MonoBehaviour
{
    [SerializeField]
    private List<Sprite> workDisplayes;
    [SerializeField]
    private List<Sprite> loafDisplayes;
    [SerializeField]
    private GameObject display;
    [SerializeField]
    private float workSpeed;
    [SerializeField]
    private float myTask;
    [SerializeField]
    private WorkerConditions worker;
    private bool chiefNearby = false;
    public enum WorkerConditions
    {
        Work,
        Loafing,
        GoHome
    }

    private void Start()
    {
        workSpeed = 0;
        GetToWork();
    }

    private void OnMouseDown()
    {
        if (chiefNearby)
        {
            if (PlayerController._instance.getCalmness > 80)
            {
                if (Random.Range(0, 10) == 0)
                    GoHome();
                else
                    GetToWork();
            }
            else
                GetToWork();
        }
    }
    private void Update()
    {
        if (worker == WorkerConditions.Work)
        {
            if (myTask <= 100)
                myTask += workSpeed * Time.deltaTime;
            else
                GoHome();
        }

    }

    private void GoHome()
    {
        worker = WorkerConditions.GoHome;
        //Animation
    }
    private void GetLoaf()
    {
        worker = WorkerConditions.Loafing;
        display.GetComponent<SpriteRenderer>().sprite = loafDisplayes[Random.Range(0, loafDisplayes.Count)];
        //Animation
    }
    private void GetToWork()
    {
        worker = WorkerConditions.Work;
        display.GetComponent<SpriteRenderer>().sprite = workDisplayes[Random.Range(0, workDisplayes.Count)];
        //Animation
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Chief"))
        {
            chiefNearby = false;
            GetLoaf();
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Chief"))
            chiefNearby = true;
    }
    public float Task
    {
        get { return myTask; }
    }
}
