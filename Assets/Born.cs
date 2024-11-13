using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Born : MonoBehaviour
{
    [SerializeField] GameObject Enemy;

    // Start is called before the first frame update
    void Start()
    {        
        InvokeRepeating("Born2", 3f, 3f);
    }

    public void Born2()
    {
        Instantiate(Enemy, transform.position, Quaternion.identity);
    }
}
