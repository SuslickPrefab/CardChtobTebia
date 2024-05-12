using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawCards : MonoBehaviour
{
    public GameObject Card1;
    public GameObject Card2;
    public GameObject PlayerArea;
    public GameObject EnemyArea;

    void Start()
    {

    }

    public void OnClick()
    {
        GameObject playerCard = Instantiate(Card1, new vector3(0, 0, 0), Quaternion.identity);
    }

}
