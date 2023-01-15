using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject _startMenu;
    [SerializeField] GameObject _questionOne;
    [SerializeField] GameObject _questionTwo;
    [SerializeField] GameObject _questionThree;
    [SerializeField] GameObject _questionFour;
    [SerializeField] GameObject _questionFive;
    [SerializeField] GameObject _questionSix;
    [SerializeField] GameObject _questionSeven;
    [SerializeField] GameObject _questionEight;
    [SerializeField] GameObject _questionNine;
    [SerializeField] GameObject _questionTen;


    void Start()
    {
        _startMenu.SetActive(true);
        _questionOne.SetActive(false); 
        _questionTwo.SetActive(false);
        _questionThree.SetActive(false);
        _questionFour.SetActive(false);
        _questionFive.SetActive(false);
        _questionSix.SetActive(false);
        _questionSeven.SetActive(false);
        _questionEight.SetActive(false);
        _questionNine.SetActive(false);
        _questionTen.SetActive(false);
    }
    public void StartQuestion()
    { 
        _startMenu.SetActive(false);
    _questionOne.SetActive(true);
    }
    public void StartOne()
    {
        _questionOne.SetActive(false);
        _questionTwo.SetActive(true);
    }
    public void StartTwo()
    {
  _questionTwo.SetActive(false);
        _questionThree.SetActive(true);
    }
}
