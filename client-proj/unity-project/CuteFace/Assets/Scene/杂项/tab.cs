using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tab : MonoBehaviour
{
    enum SelectType
    {
        P1,
        P2,
        P3,
        P4,
    }

    struct MyStruct
    {
        public int selectType;
        public GameObject btnTab;
        public GameObject unselected;
        public GameObject selected;
        public GameObject panelArea;
    }

    // Start is called before the first frame update
    MyStruct[] tabs = { };
    void Start()
    {
        print(SelectType.P1.GetHashCode());
        print(SelectType.P2.GetHashCode());
        MyStruct p1 = new MyStruct();
        p1.selectType = SelectType.P1.GetHashCode();
        tabs.SetValue(p1, p1.selectType);
        print(p1);

       // tabs[SelectType.P1.GetHashCode()] = p1;
        //tabs[SelectType.P2.GetHashCode()] = 2;
        print(tabs);

        print("»’÷æ  ‰≥ˆ  -°∑°∑°∑°∑°∑°∑°∑°∑°∑°∑°∑°∑°∑°∑°∑°∑°∑°∑");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
