using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Linq;

public class PanelController : MonoBehaviour
{
	public static PanelController panelController;
	public AnimalBase currentAnimal;
    public Dictionary<string, Action> behaviors;
	private Delegate meth;
	private bool move;
	private bool fly;
	private float timer;

    private void Awake()
    {
		panelController = this;
    }

    void Start()
	{

	}

    public void Reset()
    {
		move = false;
		fly = false;
		timer = default;
    }

	public void SpeakButton()
	{
		try
		{
			if (behaviors.Keys.Contains("speak"))
			{
				behaviors["speak"]?.Invoke();
			}
			else if (behaviors.Keys.Contains("canNot"))
			{
				behaviors["canNot"].Invoke();
			}
			else
			{
				print("Животное не содержит комманд");
			}
		}
		catch (Exception e)
		{
			print(e + " Животное не выбрано");
		}

	}



    // Update is called once per frame
    void Update()
	{
			
	}
}

