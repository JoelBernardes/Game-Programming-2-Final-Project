using System;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;

public class DayManager : MonoBehaviour
{
    [SerializeField] private int _hoursInDay;

    public int Day { get; private set; } = 1;
    public int Hour { get; private set; } = 1;
    public static DayManager Ins => _instance;
    private static DayManager _instance;

    void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Debug.LogError($"Multiple instances of DayManager in scene, destroying component on {gameObject.name}");
            Destroy(this);
            return;
        }
        else
        {
            _instance = this;
        }
    }

    public void NextDay()
    {
        Day++;
        Hour = 1;
        UIManager.Ins.UpdateTimeUI();
        UIManager.Ins.UpdateHungerUI(PlayerController.MAX_HUNGER);
    }

    public void NextHour()
    {
        if (Hour == _hoursInDay)
        {
            NextDay();
            return;
        }

        Hour++;
        UIManager.Ins.UpdateTimeUI();
    }
}
