using System;

namespace MLP_Network
{
    public class SigmoidFunction : IFunction
    {
        private readonly float _alpha = 1f;

        public SigmoidFunction(float alpha)
        {
            _alpha = alpha;
        }

        public float Compute(float x)
        {
            float r = (1 / (1 + (float)Math.Exp(-1 * _alpha * x)));
            //return r == 1f ? 0.9999999f : r;
            return r;
        }

        public float ComputeFirstDerivative(float x)
        {
            return _alpha * Compute(x) * (1 - Compute(x));
        }
    }
}
