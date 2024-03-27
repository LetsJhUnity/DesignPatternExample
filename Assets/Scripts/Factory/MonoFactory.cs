using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

//팩토리를 사용하는 스크립트
public class MonoFactory : MonoBehaviour
{
    public Button[] unitButtons;

    private void Awake()
    {

        //유닛 타입의 개수만큼 반복을 진행합니다.
        //for(int i = 0; i < Enum.GetValues(typeof(UnitType)).Length; i++)
        //{
        //    unitButtons[i].onClick.AddListener(delegate { OnButtonClick(i); });
        //    Debug.Log(i);
        //}
    }

    public void OnButtonClick(int number)
    {
        // 숫자 -> Enum
        UnitType type = (UnitType)number;
        Debug.Log(type.ToString());
        Unit unit = UnitFactory.CreateUnit(type);
    }
}

