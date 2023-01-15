using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CounterScore : MonoBehaviour
{
    public int _score;
    public int _numberTrue;
    public int _numberFalse1;
    public int _numberFalse2;
    public int _numberFalse3;


    [SerializeField] TextMeshProUGUI _textScore;
    [SerializeField] TextMeshProUGUI _textScore1;
    [SerializeField] TextMeshProUGUI _textScore2;
    [SerializeField] TextMeshProUGUI _textScore3;
    [SerializeField] TextMeshProUGUI _textScore4;
    [SerializeField] TextMeshProUGUI _textScore5;
    [SerializeField] TextMeshProUGUI _textScore6;
    [SerializeField] TextMeshProUGUI _textScore7;
    [SerializeField] TextMeshProUGUI _textScore8;
    [SerializeField] TextMeshProUGUI _textScore9;




    private void Start()
    {
        _textScore.text = _score.ToString();
        _textScore1.text=_score.ToString();
        _textScore2.text= _score.ToString();
        _textScore3.text=_score.ToString();
        _textScore4.text = _score.ToString();
        _textScore5.text = _score.ToString();
        _textScore6.text = _score.ToString();
        _textScore7.text = _score.ToString();
        _textScore8.text = _score.ToString();
        _textScore9.text = _score.ToString();

        transform.parent = null;

    }
    public void TrueQuestion()
    {
        _score += _numberTrue;
        _textScore.text = _score.ToString();
        _textScore1.text = _score.ToString();
        _textScore2.text = _score.ToString();
        _textScore3.text = _score.ToString();
        _textScore4.text = _score.ToString();
        _textScore5.text = _score.ToString();
        _textScore6.text = _score.ToString();
        _textScore7.text = _score.ToString();
        _textScore8.text = _score.ToString();
        _textScore9.text = _score.ToString();

    }
    public void FalseQuestionOne()
    {
        _score += _numberFalse1;
        _textScore.text = _score.ToString();
        _textScore1.text = _score.ToString();
        _textScore2.text = _score.ToString();
        _textScore3.text = _score.ToString();
        _textScore4.text = _score.ToString();
        _textScore5.text = _score.ToString();
        _textScore6.text = _score.ToString();
        _textScore7.text = _score.ToString();
        _textScore8.text = _score.ToString();
        _textScore9.text = _score.ToString();

    }
    public void FalseQuestionTwo()
    {
        _score += _numberFalse2;
        _textScore.text = _score.ToString();
        _textScore1.text = _score.ToString();
        _textScore2.text = _score.ToString();
        _textScore3.text = _score.ToString();
        _textScore4.text = _score.ToString();
        _textScore5.text = _score.ToString();
        _textScore6.text = _score.ToString();
        _textScore7.text = _score.ToString();
        _textScore8.text = _score.ToString();
        _textScore9.text = _score.ToString();
    }
    public void FalseQuestionThree()
    {
        _score += _numberFalse3;
        _textScore.text = _score.ToString();
        _textScore1.text = _score.ToString();
        _textScore2.text = _score.ToString();
        _textScore3.text = _score.ToString();
        _textScore4.text = _score.ToString();
        _textScore5.text = _score.ToString();
        _textScore6.text = _score.ToString();
        _textScore7.text = _score.ToString();
        _textScore8.text = _score.ToString();
        _textScore9.text = _score.ToString();

    }
}
