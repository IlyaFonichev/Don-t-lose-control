public class Stress
{
    private int _currentStress;
    private int _maxStress;

    public Stress(int _currentStress, int _maxStress)
    {
        this._currentStress = _currentStress;
        this._maxStress = _maxStress;
    }

    public void PlusStress(int stress)
    {
        _currentStress += stress;
        PlayerStaticEvents.changeStressInterface?.Invoke(PlayerController.GetPlayerStress());
    }

    public void MinusStress(int stress) 
    {
        _currentStress -= stress;
        PlayerStaticEvents.changeStressInterface?.Invoke(PlayerController.GetPlayerStress());
    }

    public void KillStress()
    {
        _currentStress = 0;
        PlayerStaticEvents.changeStressInterface?.Invoke(PlayerController.GetPlayerStress());
    }


    public int GetCurrentStress()
    {
        return _currentStress;
    }

    public int GetMaxStress()
    {
        return _maxStress;
    }
}
