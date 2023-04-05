using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oct : MonoBehaviour
{
    public GameObject octattack;
    public Transform shootpostf;
    public KeyCode shootingKey;
    public int power;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("문어 등장");
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector3.up * 3f);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject arrowCloneObj = Instantiate(octattack);
            arrowCloneObj.transform.position = shootpostf.position;
        }
    }
}
