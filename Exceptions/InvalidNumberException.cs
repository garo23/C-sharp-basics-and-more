using System;

class InvalidNumberException : Exception {
    private int _startValue;
    private int _endValue;
    public InvalidNumberException(int startValue, int endValue)
    {
        _startValue = startValue;
        _endValue = endValue;
    }

    public override string Message => $"Invalid number. It should be between {_startValue} and {_endValue}";
}


