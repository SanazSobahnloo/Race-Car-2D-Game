using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

public class FuelController : MonoBehaviour
{
    public static FuelController instance;

    [SerializeField] private Image _fuelImage;
    [SerializeField, Range(0.1f, 5f)] private float _fuelDrainSpeed = 1f;
    [SerializeField] private float _maxFuelAmount = 100f;

    private float _currentFuelAmount;


    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        _currentFuelAmount = _maxFuelAmount;
        UpdateUI();
    }
    private void Update()
    {
        _currentFuelAmount -= Time.deltaTime * _fuelDrainSpeed;
        // if (_currentFuelAmount <= 0)
        // {
        //     _currentFuelAmount = 0; 
        // }
        UpdateUI();
    }
    private void UpdateUI()
    {
        _fuelImage.fillAmount = _currentFuelAmount / _maxFuelAmount;
    }
}
