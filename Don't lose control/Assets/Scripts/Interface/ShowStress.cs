using UnityEngine;
using UnityEngine.UI;

public class ShowStress : MonoBehaviour
{
    [SerializeField] private Image _parentImageStress;
    [SerializeField] private Image _childImageStress;

    private void Awake()
    {
        PlayerStaticEvents.changeStressInterface += onChangeStressInterface;
    }

    private void OnDestroy()
    {
        PlayerStaticEvents.changeStressInterface -= onChangeStressInterface;
    }


    private void onChangeStressInterface(Stress stress)
    {
        Vector3 parentPos = _parentImageStress.transform.position;
        float oneUnit = 0.035f;
        Vector3 shfit = new Vector3(0f, ((float)stress.GetMaxStress() - stress.GetCurrentStress()) * oneUnit, 0f);
        _childImageStress.transform.position = parentPos - shfit;
    }

}
