using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;
/// <summary>
/// 
/// </summary>
public class MainClass : MonoBehaviour
{
    [SerializeField]
    List<GameObject> go;
    List<IWayOut> list = new List<IWayOut>();

    void Awake()
    {
        list.Add(go[0].GetComponent<Forest>());
        list.Add(go[1].GetComponent<Meadow>());
    }

    public void AnyMethod(IWayOut anyClass)
    {
        print("132");
        anyClass?.GoingOut();
    }

    void Start()
    {
        foreach (var item in list)
        {
            item?.GoingOut();
        }
    }
    
    void Update()
    {
        
    }
}
