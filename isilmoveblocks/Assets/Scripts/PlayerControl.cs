using UnityEngine;
using UnityEngine.AI;

public class PlayerControl : MonoBehaviour
{
    public Camera cam;
    public NavMeshAgent agent;
    public GameObject box;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        box = GameObject.FindGameObjectWithTag("Box");
        agent.SetDestination(box.transform.position);

    }


    // Update is called once per frame
    void Update()
    {
        /*

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);
            }

        }
        */
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Deneme")
        {
            agent.SetDestination(agent.transform.position);
        }

        else
        {
            agent.SetDestination(box.transform.position);
        }


    }


}
