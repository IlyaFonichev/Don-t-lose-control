using UnityEngine;

public class PlayerStaticEvents : MonoBehaviour
{
    public delegate void ChangeStressInterface(Stress stress);
    public static ChangeStressInterface changeStressInterface;
}
