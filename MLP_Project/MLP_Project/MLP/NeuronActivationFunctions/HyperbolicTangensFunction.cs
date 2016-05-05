using System;

namespace MLP_Network
{
    public class HyperbolicTangensFunction : IFunction
    {

        private float _alpha = 1;

        public HyperbolicTangensFunction(float alpha)
        {
            _alpha = alpha;
        }

        public float Compute(float x)
        {
            return (float)(Math.Tanh(_alpha * x));
        }

        public float ComputeFirstDerivative(float x)
        {
            float t = (float)Math.Tanh(_alpha * x);
            return _alpha * (1 - t * t);
        }
    }
}
