using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MoleSpawner : MonoBehaviour
{
    //public class theMoleSpawner : MoleSpawner
    //{
        //public bool theMole;

        //public theMoleSpawner(bool t)
        //{
            //theMole = t;
        //}
    //}

    private float spawnRate = 2;
    public GameObject molePrefab;
    GameObject g;
    float spawnElapsed = 0;
    [SerializeField] Score myScore;
    public bool DefClick = false;
    //public MoleSpawner Molee;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnElapsed += Time.deltaTime;

        if(spawnElapsed >= spawnRate)
        {
            Spawn();
            spawnElapsed = 0;
        }
        if (DefClick)
        {
            Clicked();
            DefClick = false;
        }
    }

    private void Spawn()
    {
        float x = Random.Range(50, 1100);
        float y = Random.Range(50, 600);
        g = Instantiate(molePrefab);
        g.transform.GetChild(0).position = new Vector3(x, y, 0);
        GameObject.Destroy(g, spawnRate+0.05f);
    }

    public void Clicked()
    {
        myScore.Points++;
        GameObject.Destroy(g);
        if (spawnRate > 0.55)
            spawnRate = spawnRate - 0.025f;
    }

}
