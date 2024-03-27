using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrackUse : MonoBehaviour
{
    BarrackFactory barrackFactory = null;
    GameObject unit1 = null;
    GameObject unit2 = null;

    private void Start()
    {
        barrackFactory = GetComponent<BarrackFactory>();

        unit1 = barrackFactory.createUnit(UnitType1.Marine);
        unit2 = barrackFactory.createUnit(UnitType1.Firebat);

        //StartCoroutine("UnitAction");
        unit1.GetComponent<Unit1>().Attack();
        unit2.GetComponent<Unit1>().Attack();
    }

/*    IEnumerator UnitAction()
    {
        yield return new WaitForSeconds(0.2f);

        unit1.GetComponent<Unit1>().Attack();
        unit2.GetComponent<Unit1>().Attack();
    }*/
}
