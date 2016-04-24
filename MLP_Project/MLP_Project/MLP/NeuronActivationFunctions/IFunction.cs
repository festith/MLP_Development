namespace MLP_Network
{
    public interface IFunction
    {
        float Compute(float x);
        float ComputeFirstDerivative(float x);
    }
}
