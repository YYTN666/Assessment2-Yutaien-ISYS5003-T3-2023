using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControl : MonoBehaviour
{
    public GameObject ship;
    public float value1;
    public float value2;
    public Vector3 sizeChange;



    public void Moveleft()
    {
        value1 = value1 - 3f ;
        ship.transform.position = new Vector3(value1 , value2, 150);
     }
    public void Moveright()
    {
        value1 = value1 + 3f;
        ship.transform.position = new Vector3(value1 , value2, 150);
    }
    public void Moveup()
    {
        value2 = value2 + 3f;
        ship.transform.position = new Vector3( value1, value2, 150);
    }
    public void Movedown()
    {
        value2 = value2 - 3f;
        ship.transform.position = new Vector3( value1, value2, 150);
    }


    public void Rotateleft1()
    {
        ship.transform.Rotate(0f, 0f, 20f);
    }
    public void Rotateright1()
    {
        ship.transform.Rotate(0f, 0f, -20f);
    }
    public void Rotateleft2()
    {
        ship.transform.Rotate(0f, 20f, 0f);
    }
    public void Rotateright2()
    {
        ship.transform.Rotate(0f, -20f, 0f);
    }


    public void Grow()
    {
        ship.transform.localScale = ship.transform.localScale + sizeChange;
    }
    public void Decrease()
    {
        ship.transform.localScale = ship.transform.localScale - sizeChange;
    }


    public void Resetship()
    {
        ship.transform.position = new Vector3(0, 0, 150);
        value1 = 0;
        value2 = 0;
        ship.transform.rotation = Quaternion.Euler(new Vector3(0, -90, 0));
        ship.transform.localScale = new Vector3(1, 1, 1);
    }


}
