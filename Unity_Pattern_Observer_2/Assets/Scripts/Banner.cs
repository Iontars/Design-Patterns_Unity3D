using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using Interfaces;
using UnityEngine;
using UnityEngine.UI;

public class Banner : MonoBehaviour, IObserver
{
    [SerializeField] private Text _text;
    private string ShowMessage  => "Is Fallen";

    private void Awake()
    {
        
    }

    private void Start()
    {
        
    }

    private void OnEnable()
    {
        Ball.BallFallen += DoAction;
    }
    private void OnDisable()
    {
        Ball.BallFallen -= DoAction;
    }

    public void DoAction(object obj)
    {
        Ball ball = obj as Ball;
        if (ball != null) GetComponent<Image>().material.color = ball.ThisColor;
        _text.text = ShowMessage;
    }
}
